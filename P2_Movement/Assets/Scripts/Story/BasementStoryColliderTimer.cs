using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementStoryColliderTimer : MonoBehaviour
{
    [SerializeField]
    private string tagStory00;
    [SerializeField]
    private string tagStory01;

    [SerializeField]
    private GameObject story00; //(Basement: 015
    [SerializeField]
    private bool hasStory00Finished;

    [SerializeField]
    private GameObject story01; //(Basement: 016
    [SerializeField]
    private bool hasStory01Finished;


    private void Start()
    {
        //Find all the colliders
        GameObject currentStory00 = GameObject.FindWithTag(tagStory00);
        GameObject currentStory01 = GameObject.FindWithTag(tagStory01);


        //Get all the comp
        HasStoryColliderActivated storySavedValue00 = currentStory00.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue01 = currentStory01.GetComponent<HasStoryColliderActivated>();

        // if everything is already played and player just return to check -> no need for timer
        if (storySavedValue00.IsStoryVoicePlayed == true &&
            storySavedValue01.IsStoryVoicePlayed == true)
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

        //Find all the colliders >> Must you hardcode ;_;
        GameObject currentStory00 = GameObject.FindWithTag(tagStory00);
        GameObject currentStory01 = GameObject.FindWithTag(tagStory00);


        //Get all the comp
        HasStoryColliderActivated storySavedValue00 = currentStory00.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue01 = currentStory01.GetComponent<HasStoryColliderActivated>();


        //015
        if (storySavedValue00.IsStoryVoicePlayed == true && story00.activeSelf == false && hasStory00Finished == false)
        {
            hasStory00Finished = true;
            story01.SetActive(true);
            return;
        }

        //016
        else if (storySavedValue01.IsStoryVoicePlayed == true && story01.activeSelf == false && hasStory01Finished == false)
        {
            hasStory01Finished = true;
            return;
        }

        else
        {
            return;
        }
    }
}
