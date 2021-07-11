using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerLoadVolume : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject savedVolumeValue = GameObject.Find("BackgroundMusic");
        savedVolumeValue.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumePreference");
    }

}
