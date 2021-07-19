using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtticStoryColliderTimer : MonoBehaviour
{
    [SerializeField]
    private string tagStory00;
    [SerializeField]
    private string tagStory01;
    [SerializeField]
    private string tagStory02;
    [SerializeField]
    private string tagStory03;

    [SerializeField]
    private GameObject story00; //(Attic: 002
    [SerializeField]
    private bool hasStory00Finished;

    [SerializeField]
    private GameObject story01; //(Attic: 003
    [SerializeField]
    private bool hasStory01Finished;

    [SerializeField]
    private GameObject story02; //(Attic: 004
    [SerializeField]
    private bool hasStory02Finished;

    [SerializeField]
    private GameObject story03; //(Attic: 006
    [SerializeField]
    private bool hasStory03Finished;


    private void Start()
    {
        //Find all the colliders >> Must you hardcode ;_;
        GameObject currentStory00 = GameObject.FindWithTag(tagStory00);
        GameObject currentStory01 = GameObject.FindWithTag(tagStory01);
        GameObject currentStory02 = GameObject.FindWithTag(tagStory02);
        GameObject currentStory03 = GameObject.FindWithTag(tagStory03);

        //Get all the comp
        HasStoryColliderActivated storySavedValue00 = currentStory00.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue01 = currentStory01.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue02 = currentStory02.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue03 = currentStory03.GetComponent<HasStoryColliderActivated>();

        // if everything is already played and player just return to check -> no need for timer
        if (storySavedValue00.IsStoryVoicePlayed == true && 
            storySavedValue01.IsStoryVoicePlayed == true && 
            storySavedValue02.IsStoryVoicePlayed == true && 
            storySavedValue03.IsStoryVoicePlayed == true )
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        DominoActivationTimer();
    }



    void DominoActivationTimer()
    {
        //1st (00) Collider will be active -> Domino effect

        //Find all the colliders >> Must you hardcode cuz me dumb ;_; >> No more hard code  = Inspector :D
        GameObject currentStory00 = GameObject.FindWithTag(tagStory00);
        GameObject currentStory01 = GameObject.FindWithTag(tagStory01);
        GameObject currentStory02 = GameObject.FindWithTag(tagStory02);
        GameObject currentStory03 = GameObject.FindWithTag(tagStory03);

        //Get all the comp
        HasStoryColliderActivated storySavedValue00 = currentStory00.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue01 = currentStory01.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue02 = currentStory02.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue03 = currentStory03.GetComponent<HasStoryColliderActivated>();


        //002 : 003, 004, 006 are off
        if (storySavedValue00.IsStoryVoicePlayed == true && story00.activeSelf == false && hasStory00Finished == false)
        {
            hasStory00Finished = true;
            story01.SetActive(true);
            return;
        }

        //003 : 002, 004, 006 are off
        else if (storySavedValue01.IsStoryVoicePlayed == true && story01.activeSelf == false && hasStory01Finished == false)
        {
            hasStory01Finished = true;
            story02.SetActive(true);
            return;
        }

        //004 : 002, 003, 006 are off
        else if (storySavedValue02.IsStoryVoicePlayed == true && story02.activeSelf == false && hasStory02Finished == false)
        {
            hasStory02Finished = true;
            story03.SetActive(true);
            return;
        }

        //006: 002, 003, 004 are off
        else if (storySavedValue03.IsStoryVoicePlayed == true && story03.activeSelf == false && hasStory03Finished == false)
        {
            hasStory03Finished = true;
            return;
        }

        else
        {
            return;
        }
    }

}
