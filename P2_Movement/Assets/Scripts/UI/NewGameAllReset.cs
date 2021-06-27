using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NewGameAllReset : MonoBehaviour
{
    public void PrefReset()
    {
        PlayerPrefs.DeleteAll();

        string filePath = Application.persistentDataPath + "/Playerdata.json";
        File.Delete(filePath);

        Debug.Log("All things are deleted");
    }

}
