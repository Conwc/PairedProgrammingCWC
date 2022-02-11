using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventManager : MonoBehaviour
{

    public event System.Action<float> SpacebarPress;
    public float sentFloatValue;
    public void ButtonPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SpacebarPress?.Invoke(sentFloatValue);
            Debug.Log("Invoked SoacebarPress event!");

        }
    }
}
