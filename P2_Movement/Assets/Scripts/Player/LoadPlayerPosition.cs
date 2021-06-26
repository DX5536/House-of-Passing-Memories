using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerPosition : MonoBehaviour
{
    //private float x, y, z;
    private float rotationX, rotationY, rotationZ;


    public void Start()
    {

        LoadPosition();
        LoadRotation();
    }

    private void LoadPosition()
    {

        Vector3 loadPos = Vector3.zero;

        loadPos.x = PlayerPrefs.GetFloat("PlayerX");
        loadPos.y = PlayerPrefs.GetFloat("PlayerY");
        loadPos.z = PlayerPrefs.GetFloat("PlayerZ");

        transform.position = loadPos;

        PlayerPrefs.Save();

        Debug.Log("I should load!");

    }
 
    private void LoadRotation()
    {
        rotationX = PlayerPrefs.GetFloat("PlayerRotationX");
        rotationY = PlayerPrefs.GetFloat("PlayerRotationY");
        rotationZ = PlayerPrefs.GetFloat("PlayerRotationZ");

        transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);

        PlayerPrefs.Save();
    }
}
