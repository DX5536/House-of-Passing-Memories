using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    private int currentSceneIndex;

    private bool currentElevatorDoorValue;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SaveElevatorValue();
            LoadMainMenu();
        }
    }

    //Public cuz GoodEnding-Button use this method too
    public void LoadMainMenu()
    {
        //Save the current playing Scene's index (Build Setting) in var currentSceneIndex
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);

        //Load our MenuScene -> BuildIndex 0
        SceneManager.LoadScene(0);
    }

    private void SaveElevatorValue()
    {
        //Save "has ElevatorDoor activated before" value
        GameObject inBetweenElevatorValue = GameObject.Find("SaveValueForElevator");
        //Idiot-Test
        if (inBetweenElevatorValue) //if this is found
        {
            HasElevatorDoorDestroyedBefore hasElevatorDoorDestroyedBefore = inBetweenElevatorValue.GetComponent<HasElevatorDoorDestroyedBefore>();
            currentElevatorDoorValue = hasElevatorDoorDestroyedBefore.IsElevatorDestroyed;

            PlayerPrefs.SetInt("SavedElevatorDoor", currentElevatorDoorValue ? 1 : 0);
        }
        
    }

    private void SaveStoryValue()
    {
        GameObject inBetween002Value = GameObject.Find("SaveValueForStoryVoice002");

        if (inBetween002Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween002Value.GetComponent<HasStoryColliderActivated>();
            bool current002Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved002Voice", current002Value ? 1 : 0);
        }
    }
    
}
