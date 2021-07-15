using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryColliderManager : MonoBehaviour
{
    [SerializeField]
    private GameObject whichStoryCollider;

    [SerializeField]
    private string whichAudioVoiceLineLocation;

    [SerializeField]
    private GameObject whichSaveValue;


    private void Awake()
    {
        CheckSaveValueForObjectActivity();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayStoryVoice();
            Debug.Log("Bla bla!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DeactivateGameObject();
        }

        //CheckSaveValueForObjectActivity();
        //DeactivateGameObject();

        Debug.Log("Exit Collider!");
    }

    private void Update()
    {
        StopStoryVoice();
        //CheckSaveValueForObjectActivity();
    }

    void PlayStoryVoice()
    {
        //Find the storyCollider
        GameObject currentStoryCollider = GameObject.Find(name: whichStoryCollider.name);
        //Get Comp storyAudio-Comp and save in local var
        StoryAudio storyAudio = currentStoryCollider.GetComponent<StoryAudio>();

        //Find the saveValue
        GameObject currentStorySaveValue = GameObject.Find(whichSaveValue.name);
        //Get the value and save in local var
        HasStoryColliderActivated hasStoryColliderActivated = currentStorySaveValue.GetComponent<HasStoryColliderActivated>();

        //Find Player
        GameObject currentPlayer = GameObject.FindGameObjectWithTag("Player");
        //Get controller-comp and save in local Var
        FPSController fPSController = currentPlayer.GetComponent<FPSController>();


        //Check if the chosen storyAudio is the same as the one with the chosen Collider Box -> If yes, play line
        if (storyAudio.AudioVoiceLineLocation == whichAudioVoiceLineLocation)
        {
            storyAudio.AudioVoiceLine.enabled = true;

            //The GameObject with StoryAudio-Script to be played
            storyAudio.AudioVoiceLine.Play();

            //after voice finished -> isStoryVoicedPlayed will be mark as true
            hasStoryColliderActivated.IsStoryVoicePlayed = true;

            //If audio is playing -> Player can't move
            if (storyAudio.AudioVoiceLine.isPlaying == true)
            {
                fPSController.CanMove = false;
            }

        }
    }

    void StopStoryVoice()
    {
        //Find the storyCollider
        GameObject currentStoryCollider = GameObject.Find(whichStoryCollider.name);
        //Get Comp storyAudio-Comp and save in local var
        StoryAudio storyAudio = currentStoryCollider.GetComponent<StoryAudio>();

        //Find the saveValue
        GameObject currentStorySaveValue = GameObject.Find(whichSaveValue.name);
        //Get the value and save in local var
        HasStoryColliderActivated hasStoryColliderActivated = currentStorySaveValue.GetComponent<HasStoryColliderActivated>();

        //Find Player
        GameObject currentPlayer = GameObject.FindGameObjectWithTag("Player");
        //Get controller-comp and save in local Var
        FPSController fPSController = currentPlayer.GetComponent<FPSController>();

        if (storyAudio.AudioVoiceLine.isPlaying == false)
        {
            fPSController.CanMove = true;
            storyAudio.AudioVoiceLine.enabled = false;
        }

        else
        {
            return;
        }
    }

    void DeactivateGameObject()
    {
        //Find the saveValue
        GameObject currentStorySaveValue = GameObject.Find(whichSaveValue.name);
        //Get the value and save in local var
        HasStoryColliderActivated hasStoryColliderActivated = currentStorySaveValue.GetComponent<HasStoryColliderActivated>();

        hasStoryColliderActivated.IsStoryVoicePlayed = true;
        this.gameObject.SetActive(false);
    }

    void CheckSaveValueForObjectActivity()
    {
        //Find the saveValue
        GameObject currentStorySaveValue = GameObject.Find(whichSaveValue.name);
        //Get the value and save in local var
        HasStoryColliderActivated hasStoryColliderActivated = currentStorySaveValue.GetComponent<HasStoryColliderActivated>();

        if (hasStoryColliderActivated.IsStoryVoicePlayed == true)
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
        }
    }
}
