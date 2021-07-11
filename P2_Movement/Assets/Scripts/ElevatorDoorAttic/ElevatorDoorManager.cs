using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject savedElevatorValue = GameObject.Find("SaveValueForElevator");
        HasElevatorDoorDestroyedBefore hasElevatorDoorDestroyedBefore  = savedElevatorValue.GetComponent<HasElevatorDoorDestroyedBefore>();

        hasElevatorDoorDestroyedBefore.isElevatorDestroyed = true;

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