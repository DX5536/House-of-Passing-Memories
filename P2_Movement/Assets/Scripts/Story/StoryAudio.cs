using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryAudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioVoiceLine;

    public AudioSource AudioVoiceLine
    {
        get { return audioVoiceLine; }
        set { audioVoiceLine = value; }
    }

    [SerializeField]
    private string audioVoiceLineLocation;

    public string AudioVoiceLineLocation
    {
        get { return audioVoiceLineLocation; }
        set { audioVoiceLineLocation = value; }
    }
}
