using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveValueForGFSpawner : MonoBehaviour
{
    private int saveValueForSpawn;

    public int SaveValueForSpawn
    {
        get { return saveValueForSpawn; }
        set { saveValueForSpawn = value; }
    }

    private void Awake()
    {
        //Don't destroy GFValue when change scene
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GFSpawnValue");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

    }
}
