using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Script : MonoBehaviour
{
    public EventManager evMan;
    void Start()
    {
        evMan.SpacebarPress += MoveUp;
    }

    // Update is called once per frame
    private void OnDestroy()
    {
        evMan.SpacebarPress -= MoveUp;
    }

    void MoveUp()
    {
        Debug.Log("Cube 1 is moving up!");
        transform.position += Vector3.up;
    }
}
