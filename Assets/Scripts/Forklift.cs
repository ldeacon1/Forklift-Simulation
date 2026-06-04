using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Forklift : MonoBehaviour
{
    [SerializeField] private WheelCollider wheel1col;
    [SerializeField] private WheelCollider wheel2col;
    [SerializeField] private WheelCollider wheel3col;
    [SerializeField] private WheelCollider wheel4col;
    [SerializeField] private Transform wheel1;
    [SerializeField] private Transform wheel2;
    [SerializeField] private float breakforce;

    private float current_brakeforce = 0f;
    private bool forward = false;
    private bool backward = false;
    private float maxturnangle = 20f;
    private float currentturnangle = 0f;
    public float acceleration;
    public float maxSpeed;
    public float curSpeed = 0.0f;

    [SerializeField] private Loading_Bay_Door[] Doors;

    private void FixedUpdate()
    {
        if (forward)
        {
            curSpeed += acceleration;
            if (curSpeed > maxSpeed)
            {
                curSpeed = maxSpeed;
            }
        }
        
        if (backward)
        {
            curSpeed -= acceleration;
            if (curSpeed < -maxSpeed)
            {
                curSpeed = -maxSpeed;
                
            }
        }
  
        wheel1col.motorTorque = curSpeed;
        wheel2col.motorTorque = curSpeed;

        wheel1col.brakeTorque = current_brakeforce;
        wheel2col.brakeTorque = current_brakeforce;
        wheel3col.brakeTorque = current_brakeforce;
        wheel4col.brakeTorque = current_brakeforce;

        currentturnangle = maxturnangle * -Input.GetAxis("Horizontal");
        wheel1col.steerAngle = currentturnangle;
        wheel2col.steerAngle = currentturnangle;

        updatewheel(wheel1col, wheel1);
        wheel1.transform.Rotate(0, 0, 90);
        updatewheel(wheel2col, wheel2);
        wheel2.transform.Rotate(0, 0, 90);
    }
    public void brake(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            current_brakeforce = breakforce;
        }
    }
    public void stopbrake(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            current_brakeforce = 0f;
        }
    }
    public void Drive(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            forward = true;
        }
        if(ctx.canceled)
        {
            forward = false;
            curSpeed = 0f;
        }
    }

    public void Reverse(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            backward = true;
        }
    }
    public void Stationary(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            curSpeed = 0f;
            forward = false;
            backward = false;
        }
    }
    public void updatewheel(WheelCollider col, Transform tran)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);
        
        tran.position = position;
        tran.rotation = rotation; 
    }
    public void Interact(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            for (int i = 0; i < Doors.Length; i++)
            {
                Doors[i].Raise();
                Doors[i].Check_lock();
            }
        }
    }
}