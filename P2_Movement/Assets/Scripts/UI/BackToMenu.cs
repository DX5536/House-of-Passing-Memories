using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    private int currentSceneIndex;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }

    void LoadMainMenu()
    {
        //Save the current playing Scene's index (Build Setting) in var currentSceneIndex
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex);

        //Load our MenuScene -> BuildIndex 0
        SceneManager.LoadScene(0);
    }
    
}
