using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveValueForGFSpawner : MonoBehaviour
{
    public int saveValueForSpawn;

    private void Awake()
    {
        //Don't destroy BG music when change scene
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GFSpawnValue");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

    }
}
