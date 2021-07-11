using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasElevatorDoorDestroyedBefore : MonoBehaviour
{
    public bool isElevatorDestroyed;

    private void Awake()
    {
        //Don't destroy ElevatorDoor value when change scene
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ElevatorDoorDestroyedValue");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

    }
}
