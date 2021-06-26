using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    private int sceneToContinue;

    public void ContinueGameButton()
    {
        //Load the savedScene from BackToMenu.cs
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        //Idiot-Proof
        if (sceneToContinue != 0)
        {
            SceneManager.LoadScene(sceneToContinue);
            
        }

        //If there is no SavedScene -> Doesnt work
        else
        {
            return;
        }
    }

}
