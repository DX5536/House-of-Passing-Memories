using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SavePosition();
            SaveRotation();
        }
    }

    private float x, y, z;

    void SavePosition()
    {
        x = player.transform.position.x;
        y = player.transform.position.y;
        z = player.transform.position.z;

        PlayerPrefs.SetFloat("PlayerX", x);
        PlayerPrefs.SetFloat("PlayerY", y);
        PlayerPrefs.SetFloat("PlayerZ", z);
    }

    void SaveRotation()
    {
        PlayerPrefs.SetFloat("PlayerRotationX", player.transform.eulerAngles.x);
        PlayerPrefs.SetFloat("PlayerRotationY", player.transform.eulerAngles.y);
        PlayerPrefs.SetFloat("PlayerRotationZ", player.transform.eulerAngles.z);
    }
}