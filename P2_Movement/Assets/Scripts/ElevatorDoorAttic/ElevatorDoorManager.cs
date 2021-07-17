using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject savedElevatorValue = GameObject.FindGameObjectWithTag("ElevatorDoorDestroyedValue");
        HasElevatorDoorDestroyedBefore hasElevatorDoorDestroyedBefore  = savedElevatorValue.GetComponent<HasElevatorDoorDestroyedBefore>();

        hasElevatorDoorDestroyedBefore.IsElevatorDestroyed = true;

        GameObject elevatorDoor = GameObject.Find("ElevatorDoor");

        //If there is an ElevatorDoor after the entire check -> Destroy
        if(elevatorDoor != null)
        {
            Destroy(elevatorDoor.gameObject);
        }
        else
        {
            return;
        }
    }
}
