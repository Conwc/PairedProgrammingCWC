using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Script : MonoBehaviour
{
    public EventManager evMan;
    void Start()
    {
        evMan.SpacebarPress += MoveRight;
    }
    private void OnDestroy()
    {
        evMan.SpacebarPress -= MoveRight;
    }

    void MoveRight(float receivedFloat)
    {
        Debug.Log("Cube 1 is moving right!");
        transform.position += new Vector3(receivedFloat, 0f, 0f);
    }
}