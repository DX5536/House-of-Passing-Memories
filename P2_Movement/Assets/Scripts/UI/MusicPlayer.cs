using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer: MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;

    private void Awake()
    {
        //Don't destroy BG music when change scene
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        PlayMusic();
    }

    private void Update()
    {

        PlayMusic();
        StopMusic();
    }

    private void PlayMusic()
    {
        
        //If music is already playing then keep playing
        if (_audioSource.isPlaying == true)
        {
            return;
        }
        //Else Play it
        else
        {
            _audioSource.Play();
        }
    }

    private void StopMusic()
    {
        //Stop BG music at Menu
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "00_Menu")
        {
            _audioSource.Stop();
            Destroy(this.gameObject);
        }
    }
}
