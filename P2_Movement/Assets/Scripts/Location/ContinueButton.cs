using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    private int sceneToContinue;

    [SerializeField]
    private GameObject valueForSpawnPrefab;

    public void ContinueGameButton()
    {
        //Load the savedScene from BackToMenu.cs
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        //Idiot-Proof
        if (sceneToContinue != 0)
        {
            //Load scene
            SceneManager.LoadScene(sceneToContinue);

            //Make sure GF value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("GFSpawnValue");
            if (objs.Length < 1)
            {
                Instantiate(valueForSpawnPrefab);
            }

        }

        //If there is no SavedScene -> Doesnt work
        else
        {
            return;
        }

    }

}
