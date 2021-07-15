using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryColliderState : MonoBehaviour
{
    [SerializeField]
    private GameObject saveValueForStoryVoice00X;

    void Start()
    {
        GameObject savedStoryColliderValue = GameObject.Find(saveValueForStoryVoice00X.name);
        HasStoryColliderActivated hasStoryColliderActivated = savedStoryColliderValue.GetComponent<HasStoryColliderActivated>();

        if (hasStoryColliderActivated.IsStoryVoicePlayed == true)
        {
            if (gameObject != null)
            {
                this.gameObject.SetActive(false);
                //Destroy(this.gameObject);
            }
        }

        else
        {
            return;
        }
    }

}
