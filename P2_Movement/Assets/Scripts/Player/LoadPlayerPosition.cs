using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerPosition : MonoBehaviour
{
    private float x, y, z;
    private float rotationX, rotationY, rotationZ;

    private void Start()
    {
        LoadPosition();
        LoadRotation();
    }

    public void LoadPosition()
    {

        x = PlayerPrefs.GetFloat("PlayerX");
        y = PlayerPrefs.GetFloat("PlayerY");
        z = PlayerPrefs.GetFloat("PlayerZ");

        Vector3 LoadedPlayerPosition = new Vector3(x, y, z);
        transform.position = LoadedPlayerPosition;

    }
 
    public void LoadRotation()
    {
        rotationX = PlayerPrefs.GetFloat("PlayerRotationX");
        rotationY = PlayerPrefs.GetFloat("PlayerRotationY");
        rotationZ = PlayerPrefs.GetFloat("PlayerRotationZ");

        transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
    }
}
