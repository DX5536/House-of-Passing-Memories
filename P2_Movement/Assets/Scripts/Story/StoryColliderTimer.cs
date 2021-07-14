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

    // Update is called once per frame
    void Update()
    {
        //1st (00) Collider will be active -> Domino effect

        //if 00 is inactive -> activate 01 (Attic: 002
        if (story00.activeSelf == false && hasStory00Finished == false)
        {
            story01.SetActive(true);

            hasStory00Finished = true;
            return;
        }

        //if 01 is inactive -> activate 02 (Attic: 003
        if (story01.activeSelf == false && hasStory00Finished == true)
        {
            story02.SetActive(true);

            hasStory01Finished = true;
            return;
        }

        //if 02 is inactive -> activate 03 (Attic: 004
        if (story02.activeSelf == false && hasStory01Finished == true)
        {
            story03.SetActive(true);

            hasStory02Finished = true;
            return;
        }

        //if 03 is inactive -> marked story03 is finished (Attic: 006
        if (story03.activeSelf == false && hasStory02Finished == true)
        {
            hasStory03Finished = true;
            return;
        }
    }
}
