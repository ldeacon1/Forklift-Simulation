using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Forks : MonoBehaviour
{
    private Transform location;
    [SerializeField] private Transform forks;
    [SerializeField] private float liftspeed;
    [SerializeField] private float maxlift = 2.4f;
    [SerializeField] private float minlift = 9.5f;
    private bool up = false;
    private bool down = false;

    private void FixedUpdate()
    {
        lift();
    }
    public void raise(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            down = false;
            up = true;
        }
    }
    public void lower(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            down = true;
            up = false;
        }
    }
    public void stop(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            down = false;
            up = false;
        }
    }
    private void lift()
    {
        float y = forks.localPosition.y;
        if(up == true)
        {
            y += liftspeed * Time.deltaTime;
            y = Mathf.Clamp(y, minlift, maxlift);
            forks.localPosition = new Vector3(forks.localPosition.x, y, forks.localPosition.z);
        }
        if(down == true)
        {
            y -= liftspeed * Time.deltaTime;
            y = Mathf.Clamp(y, minlift, maxlift);
            forks.localPosition = new Vector3(forks.localPosition.x, y, forks.localPosition.z);
        }
    }
}
