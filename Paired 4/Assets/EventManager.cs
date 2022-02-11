using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventManager : MonoBehaviour
{

    public event System.Action SpacebarPress;
    public void ButtonPress(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SpacebarPress.Invoke();
            Debug.Log("Received button press input with context of:" + context.phase);

        }
    }
}
