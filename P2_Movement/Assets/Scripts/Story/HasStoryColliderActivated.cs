using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasStoryColliderActivated : MonoBehaviour
{
    [SerializeField]
    private bool isStoryVoicePlayed;

    public bool IsStoryVoicePlayed
    {
        get { return isStoryVoicePlayed; }
        set { isStoryVoicePlayed = value; }
    }

    [SerializeField]
    private string whichStoryVoiceIsPlayedTag;

    public string WhichStoryVoiceIsPlayed
    {
        get { return whichStoryVoiceIsPlayedTag; }
        set { whichStoryVoiceIsPlayedTag = value; }
    }

    private void Awake()
    {
        //Don't destroy ElevatorDoor value when change scene
        GameObject[] objs = GameObject.FindGameObjectsWithTag(whichStoryVoiceIsPlayedTag);

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

    }
}
