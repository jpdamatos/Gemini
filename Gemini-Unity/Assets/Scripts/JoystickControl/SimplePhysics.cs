using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePhysics : MonoBehaviour
{

    public float gainSurge;
    public float gainSway;
    public float gainYaw;

    XboxInput controls;
    Vector2 leftStick;
    Vector2 rightStick;

    private void Awake()
    {
        controls = new XboxInput();

        controls.Pilot.Translation.performed += cntxt => leftStick = cntxt.ReadValue<Vector2>();
        controls.Pilot.Translation.canceled += cntxt => leftStick = Vector2.zero;

        controls.Pilot.Sway.performed += cntxt => rightStick = cntxt.ReadValue<Vector2>();
        controls.Pilot.Sway.canceled += cntxt => rightStick = Vector2.zero;
    }


    // Update is called once per frame
    void Update()
    {
        //Vector3 m = new Vector3(leftStick.y * 3, 0, rightStick.y * 3);

        //GetComponent<Rigidbody>().velocity = m;

        //GetComponent<Transform>().Rotate(Vector3.up * leftStick.x * .5f);

        GetComponent<Rigidbody>().AddRelativeForce(rightStick.x * gainSway, 0, leftStick.y * gainSurge, ForceMode.Impulse);

        GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * leftStick.x * gainYaw);

    }

    void OnEnable()
    {
        controls.Pilot.Enable();
    }

    void OnDisable()
    {
        controls.Pilot.Disable();
    }
}
