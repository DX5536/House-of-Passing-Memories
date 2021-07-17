using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    private int sceneToContinue;

    private bool elevatorDoorToContinue;

    private bool has002ActivatedToContinue;
    private bool has003ActivatedToContinue;
    private bool has004ActivatedToContinue;
    private bool has006ActivatedToContinue;
    private bool has007ActivatedToContinue;
    private bool has015ActivatedToContinue;
    private bool has016ActivatedToContinue;
    private bool has018ActivatedToContinue;

    [SerializeField]
    private GameObject valueForSpawnPrefab;

    [SerializeField]
    private GameObject valueForElevatorPrefab;

    [SerializeField]
    private GameObject valueFor002Prefab;

    [SerializeField]
    private GameObject valueFor003Prefab;

    [SerializeField]
    private GameObject valueFor004Prefab;

    [SerializeField]
    private GameObject valueFor006Prefab;

    [SerializeField]
    private GameObject valueFor007Prefab;

    [SerializeField]
    private GameObject valueFor0015Prefab;

    [SerializeField]
    private GameObject valueFor016Prefab;

    [SerializeField]
    private GameObject valueFor018Prefab;

    public void ContinueGameButtonScene()
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

    public void ContinueGameButtonElevator()
    {
        elevatorDoorToContinue = PlayerPrefs.GetInt("SavedElevatorDoor") == 1 ? true : false;
    }

}
