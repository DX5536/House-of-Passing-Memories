using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    private int currentSceneIndex;

    private bool currentElevatorDoorValue;

    private bool current002Value;
    private bool current003Value;
    private bool current004Value;
    private bool current006Value;
    private bool current007Value;
    private bool current015Value;
    private bool current016Value;
    private bool current018Value;

    // Update is called once per frame
    void Update()
    {
        

        //Save function too
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SaveElevatorValue();

            SaveStory002Value();
            SaveStory003Value();
            SaveStory004Value();
            SaveStory006Value();
            SaveStory007Value();
            SaveStory015Value();
            SaveStory016Value();
            SaveStory018Value();

            
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
        GameObject inBetweenElevatorValue = GameObject.FindGameObjectWithTag("ElevatorDoorDestroyedValue");
        //Idiot-Test
        if (inBetweenElevatorValue) //if this is found
        {
            HasElevatorDoorDestroyedBefore hasElevatorDoorDestroyedBefore = inBetweenElevatorValue.GetComponent<HasElevatorDoorDestroyedBefore>();
            currentElevatorDoorValue = hasElevatorDoorDestroyedBefore.IsElevatorDestroyed;

            PlayerPrefs.SetInt("SavedElevatorDoor", currentElevatorDoorValue ? 1 : 0);
        }
        
    }

    private void SaveStory002Value()
    {
        GameObject inBetween002Value = GameObject.FindGameObjectWithTag("Story_002");

        if (inBetween002Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween002Value.GetComponent<HasStoryColliderActivated>();
            current002Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved002Voice", current002Value ? 1 : 0);
        }
    }

    private void SaveStory003Value()
    {
        GameObject inBetween003Value = GameObject.FindGameObjectWithTag("Story_003");

        if (inBetween003Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween003Value.GetComponent<HasStoryColliderActivated>();
            current003Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved003Voice", current003Value ? 1 : 0);
        }
    }

    private void SaveStory004Value()
    {
        GameObject inBetween004Value = GameObject.FindGameObjectWithTag("Story_004");

        if (inBetween004Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween004Value.GetComponent<HasStoryColliderActivated>();
            current004Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved004Voice", current004Value ? 1 : 0);
        }
    }

    private void SaveStory006Value()
    {
        GameObject inBetween006Value = GameObject.FindGameObjectWithTag("Story_006");

        if (inBetween006Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween006Value.GetComponent<HasStoryColliderActivated>();
            current006Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved006Voice", current006Value ? 1 : 0);
        }
    }

    private void SaveStory007Value()
    {
        GameObject inBetween007Value = GameObject.FindGameObjectWithTag("Story_007");

        if (inBetween007Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween007Value.GetComponent<HasStoryColliderActivated>();
            current007Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved007Voice", current007Value ? 1 : 0);
        }
    }

    private void SaveStory015Value()
    {
        GameObject inBetween015Value = GameObject.FindGameObjectWithTag("Story_015");

        if (inBetween015Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween015Value.GetComponent<HasStoryColliderActivated>();
            current015Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved015Voice", current015Value ? 1 : 0);
        }
    }

    private void SaveStory016Value()
    {
        GameObject inBetween016Value = GameObject.FindGameObjectWithTag("Story_016");

        if (inBetween016Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween016Value.GetComponent<HasStoryColliderActivated>();
            current016Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved016Voice", current016Value ? 1 : 0);
        }
    }

    private void SaveStory018Value()
    {
        GameObject inBetween018Value = GameObject.FindGameObjectWithTag("Story_018");

        if (inBetween018Value)
        {
            HasStoryColliderActivated hasStoryColliderActivated = inBetween018Value.GetComponent<HasStoryColliderActivated>();
            current018Value = hasStoryColliderActivated.IsStoryVoicePlayed;

            PlayerPrefs.SetInt("Saved002Voice", current018Value ? 1 : 0);
        }
    }
}
