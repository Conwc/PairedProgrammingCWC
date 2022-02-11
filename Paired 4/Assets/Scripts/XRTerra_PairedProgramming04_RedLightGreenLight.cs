using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRTerra_PairedProgramming04_RedLightGreenLight : MonoBehaviour
{
    public float speed;
    Vector3 movement;

    void Update()
    {
        transform.position += movement * Time.deltaTime * speed;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 givenMovement = context.ReadValue<Vector2>();
        movement = new Vector3(givenMovement.x, 0, givenMovement.y);
    }
}
