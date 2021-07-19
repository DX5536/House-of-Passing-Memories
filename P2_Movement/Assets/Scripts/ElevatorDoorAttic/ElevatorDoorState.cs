using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorState : MonoBehaviour
{
    private void Start()
    {
        GameObject savedElevatorValue = GameObject.FindGameObjectWithTag("ElevatorDoorDestroyedValue");
        HasElevatorDoorDestroyedBefore hasElevatorDoorDestroyedBefore = savedElevatorValue.GetComponent<HasElevatorDoorDestroyedBefore>();

        if(hasElevatorDoorDestroyedBefore.IsElevatorDestroyed == true)
        {
            Destroy(this.gameObject);
        }
    }
}
