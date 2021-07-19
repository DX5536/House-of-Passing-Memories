using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadPositionJSON : MonoBehaviour
{
    private JSONPlayer jsonPlayer;
    private string filePath;

    private void Awake()
    {
        //Save the Player's JSON stuff in var jsonPlayer
        jsonPlayer = GameObject.FindWithTag("Player").GetComponent<JSONPlayer>();

        filePath = Application.persistentDataPath + "/Playerdata.json";

        LoadToJSON();
    }
    private void Start()
    {
        //LoadToJSON();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SaveToJSON();
        }
    }

    private void SaveToJSON()
    {
        //Translation -> Save in local var
        string playerDataToSave = JsonUtility.ToJson(jsonPlayer.PlayerData);
        //Save it
        File.WriteAllText(filePath, playerDataToSave);

        Debug.Log("I have saved in JSON");
    }

    //Load when click Continue in Menu
    public void LoadToJSON()
    {
        //Idiot-Test: If File exists in filePath
        if (File.Exists(filePath))
        {
            //Read all the data and save to var loadedPlayerData
            string loadedPlayerData = File.ReadAllText(filePath);

            //Load the stuff in Game
            jsonPlayer.PlayerData = JsonUtility.FromJson<PlayerData>(loadedPlayerData);

            Debug.Log("I should load JSON");
        }

        else
        {
            Debug.Log("Oops! No file :(");
        }
    }
}
