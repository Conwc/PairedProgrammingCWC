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
    private void OnDestroy()
    {
        evMan.SpacebarPress -= MoveUp;
    }

    void MoveUp(float receivedFloat)
    {
        Debug.Log("Cube 1 is moving up!");
        transform.position += new Vector3(0f, receivedFloat, 0f);
    }
}
