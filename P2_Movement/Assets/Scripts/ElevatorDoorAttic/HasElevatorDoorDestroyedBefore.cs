using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasElevatorDoorDestroyedBefore : MonoBehaviour
{
    private bool isElevatorDestroyed;

    public bool IsElevatorDestroyed
    {
        get { return isElevatorDestroyed; }
        set { isElevatorDestroyed = value; }
    }

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
