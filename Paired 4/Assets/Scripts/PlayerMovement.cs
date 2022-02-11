using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Vector3 movementVector;
   
    // Update is called once per frame
    void Update()
    {
        transform.position += movementVector * Time.deltaTime * speed;
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 movement = context.ReadValue<Vector2>();
        Debug.Log("On Movement");
        movementVector = new Vector3(movement.x, 0, movement.y);

    }
}
