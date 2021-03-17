using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gemini.EMRS.Core;

namespace Gemini.EMRS.ScenarioGenerator {
    public class ScenarioServer : MonoBehaviour
    {
        public GameObject[] BoatPrefabs;
        public bool useLLH;
        [Range(2, 9)] public int ScenarioNumber;
        private BoatScenario[] _boatScenarios;
        private Sensor[] _sensors;
        private double nextScenarioTime;

        private float BoatLength;
        private string BoatType;

        void Start()
        {
            _sensors = Sensor.GetActiveSensors();
            Sensor.ResetSensorTime(_sensors);
            SetupBoats();
            nextScenarioTime = 0;
        }

        void FixedUpdate()
        {
            if (Sensor.SensorTimeUpdated(_sensors))
            {
                for (int boatIdx = 0; boatIdx < BoatPrefabs.Length; boatIdx++)
                {
                    nextScenarioTime = _boatScenarios[boatIdx].UpdateVessel();
                }
                Sensor.UpdateSensorTime(nextScenarioTime,_sensors);
            }
        }

        private void SetupBoats()
        {
#if UNITY_EDITOR
                string filePath = Application.dataPath + "../../../Scenarios/Scenario" + ScenarioNumber.ToString() + ".csv";

            // TODO: This path is not entirely correct for a standalone build, since the scenarios are not packaged
            // together with the rest of the build resource files when built.
#else
            string filePath = Application.dataPath + "..\\..\\..\\..\\Scenarios\\Scenario" + ScenarioNumber.ToString() + ".csv";
#endif

            BoatLength = 7;
            BoatType = "Finn";

            BoatPrefabs[0] = Instantiate(Resources.Load(BoatType, typeof(GameObject))) as GameObject;
            float length = BoatPrefabs[0].GetComponentInChildren<MeshFilter>().sharedMesh.bounds.extents.z * 100f;
            BoatPrefabs[0].transform.localScale *= (BoatLength / (length));
            _boatScenarios = new BoatScenario[BoatPrefabs.Length];
            for (int boatIndex = 0; boatIndex < _boatScenarios.Length-1; boatIndex++)
            {
                BoatPrefabs[boatIndex] = Instantiate(BoatPrefabs[boatIndex], new Vector3(0, 0, 0), Quaternion.identity);
                _boatScenarios[boatIndex] = new BoatScenario(filePath, BoatPrefabs[boatIndex], boatIndex + 1, useLLH);
            }
            _boatScenarios[_boatScenarios.Length-1] = new BoatScenario(filePath, BoatPrefabs[_boatScenarios.Length-1], _boatScenarios.Length, useLLH);
        }
    }
}