using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private Slider volumeSlider;

    private float currentVolume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVolume (float volume)
    {

        //audioSource.volume = currentVolume;
        currentVolume = volume;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("VolumePreference", currentVolume);
    }

    public void LoadSetting()
    {
        if (PlayerPrefs.HasKey("VolumePreference"))
        {
            volumeSlider.value = PlayerPrefs.GetFloat("VolumePreference");
        }

        else
        {
            volumeSlider.value = PlayerPrefs.GetFloat("VolumePreference");
        }
    }
}
