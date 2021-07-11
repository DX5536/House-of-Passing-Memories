using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void StartGameButton()
    {
        //Reset elevator door when new game
        GameObject savedElevatorValue = GameObject.Find("SaveValueForElevator");

        if (savedElevatorValue == true)
        {
            HasElevatorDoorDestroyedBefore hasElevatorDoorDestroyedBefore = savedElevatorValue.GetComponent<HasElevatorDoorDestroyedBefore>();

            hasElevatorDoorDestroyedBefore.isElevatorDestroyed = false;

            //Load Intro
            SceneManager.LoadScene(10);
        }

        else
        {
            //Load Intro
            SceneManager.LoadScene(10);
        }

        
    }
}
