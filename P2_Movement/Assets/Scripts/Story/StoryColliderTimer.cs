using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryColliderTimer : MonoBehaviour
{
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


    private void Update()
    {
        //DominoActivation();
        Dumb();
    }



    void Dumb()
    {
        //1st (00) Collider will be active -> Domino effect

        //Find all the colliders >> Must you hardcode ;_;
        GameObject currentStory00 = GameObject.FindWithTag("Story_002");
        GameObject currentStory01 = GameObject.FindWithTag("Story_003");
        GameObject currentStory02 = GameObject.FindWithTag("Story_004");
        GameObject currentStory03 = GameObject.FindWithTag("Story_006");

        //Get all the comp
        HasStoryColliderActivated storySavedValue00 = currentStory00.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue01 = currentStory01.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue02 = currentStory02.GetComponent<HasStoryColliderActivated>();
        HasStoryColliderActivated storySavedValue03 = currentStory03.GetComponent<HasStoryColliderActivated>();


        //002 : 003, 004, 006 are off
        if (storySavedValue00.IsStoryVoicePlayed == true && story00.activeSelf == false)
        {
            hasStory00Finished = true;
            story01.SetActive(true);
            return;
        }

        //003 : 002, 004, 006 are off
        else if (story00.activeSelf == true && story01.activeSelf == false && hasStory00Finished == true)
        {
            hasStory01Finished = true;
            story02.SetActive(true);
            return;
        }

        //004 : 002, 003, 006 are off //STILL THIS BITCH
        else if (storySavedValue02.IsStoryVoicePlayed == true && story02.activeSelf == false && hasStory01Finished == true)
        {
            hasStory02Finished = true;
            story03.SetActive(true);
            return;
        }

        //006: 002, 003, 004 are off
        else if (storySavedValue03.IsStoryVoicePlayed == true)
        {
            hasStory03Finished = true;
            return;
        }

        else
        {
            return;
        }
    }

    void DominoActivation()
    {
        //Find all the colliders
        GameObject currentStory00 = GameObject.Find(story00.name);
        GameObject currentStory01 = GameObject.Find(story01.name);
        GameObject currentStory02 = GameObject.Find(story02.name);
        GameObject currentStory03 = GameObject.Find(story03.name);

        //Get all the comp
        StoryColliderManager storyColliderManager00 = currentStory00.GetComponent<StoryColliderManager>();
        StoryColliderManager storyColliderManager01 = currentStory01.GetComponent<StoryColliderManager>();
        StoryColliderManager storyColliderManager02 = currentStory02.GetComponent<StoryColliderManager>();
        StoryColliderManager storyColliderManager03 = currentStory03.GetComponent<StoryColliderManager>();

    }
}
