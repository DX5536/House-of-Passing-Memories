using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPosition : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SavePosition();
            SaveRotation();

            Debug.Log("I have saved!");
        }
    }

    void SavePosition()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);

        PlayerPrefs.Save();
        
    }

    void SaveRotation()
    {
        PlayerPrefs.SetFloat("PlayerRotationX", transform.eulerAngles.x);
        PlayerPrefs.SetFloat("PlayerRotationY", transform.eulerAngles.y);
        PlayerPrefs.SetFloat("PlayerRotationZ", transform.eulerAngles.z);

        PlayerPrefs.Save();
    }
}