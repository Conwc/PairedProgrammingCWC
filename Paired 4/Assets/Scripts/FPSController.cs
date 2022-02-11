using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSController : MonoBehaviour
{
    public Transform camTrans;
    public float xSensitivity, ySensitivity;
    public float speed;
    Vector3 movement;
    public float projectileSpeed;
    public Transform projectileSpawnPoint;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        transform.position += transform.TransformDirection(movement) * speed * Time.deltaTime;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 receivedVector2 = context.ReadValue<Vector2>();
        movement = new Vector3(receivedVector2.x, 0f, receivedVector2.y);
    }
    public void MouseX(InputAction.CallbackContext context)
    {
        float mouseXDelta = context.ReadValue<float>() * Time.deltaTime * xSensitivity;
        transform.Rotate(0f, mouseXDelta, 0f);
    }

    public void MouseY(InputAction.CallbackContext context)
    {
        float mouseYDelta = context.ReadValue<float>() * Time.deltaTime * ySensitivity;
        Vector3 desiredRotation = camTrans.eulerAngles + new Vector3(-mouseYDelta, 0f, 0f);

        if (desiredRotation.x > 180)
        {
            desiredRotation.x -= 360;
        }
        desiredRotation.x = Mathf.Clamp(desiredRotation.x, -85f, 85f);
        camTrans.rotation = Quaternion.Euler(desiredRotation);
    }

    public void OnClick(InputAction.CallbackContext context);
    {   
        if (context.performed)
        {
            Debug.Log("Clicked!");
            GameObject projectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            projectile.transform.position = projectileSpawnPoint.position;
            projectile.AddComponent<Rigidbody>();
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward* projectileSpeed);

        }
    }
}
