using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gemini.Forcecontrol;
using Grpc.Core;
using System.Threading.Tasks;
using Gemini.Core;
using System.Threading;
using System;

namespace Gemini.Networking.Services
{
    public class ForceControlServiceImpl : ForceControl.ForceControlBase
    {

        private ForceController[] _forceControllers;

        private Vector3 _force = new Vector3();
        private Vector3 _torque = new Vector3();

        private float surge_Gain = 10f;
        private float sway_Gain = 1.5f;
        private float yaw_Gain = 1/5000f; 

        public ForceControlServiceImpl(ForceController[] forceControllers)
        {
            this._forceControllers = forceControllers; 
        }

        public override async Task<ForceResponse> ApplyForce(ForceRequest request, ServerCallContext context)
        {

            _force.x = Mathf.Clamp(request.GeneralizedForce.X,-100f,100f) * surge_Gain;
            _force.y = Mathf.Clamp(request.GeneralizedForce.Y, -100f, 100f) * sway_Gain;
            _force.z = 0; //request.GeneralizedForce.Z;

            _torque.x = 0; //request.GeneralizedForce.K;
            _torque.y = 0; //request.GeneralizedForce.M;
            _torque.z = Mathf.Clamp(request.GeneralizedForce.N, -100f, 100f) * yaw_Gain;


            // Create the event that triggers when the execution of the action is finished.
            ManualResetEvent signalEvent = new ManualResetEvent(false);

            ThreadManager.ExecuteOnMainThread(() =>
            {
                foreach (ForceController forceController in _forceControllers)
                {
                    if (forceController.name == request.VesselId)
                    {
                        forceController.Force = ConventionTransforms.ForceNEDToUnity(_force);
                        forceController.Torque = ConventionTransforms.TorqueNEDToUnity(_torque);
                    }
                }

                signalEvent.Set();
            });

            // Wait for the event to be triggered from the action, signaling that the action is finished
            // This is required becaue we are reading and depending on state from a resource running on the
            // Unity main thread.
            signalEvent.WaitOne();
            signalEvent.Close();


            return await Task.FromResult(new ForceResponse
            {
                Success = true,
            });

        }
    }
}

