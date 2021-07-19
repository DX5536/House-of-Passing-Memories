using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NewGameAllReset : MonoBehaviour
{
    public void PrefReset()
    {
        PlayerPrefs.DeleteAll();

        //In case of player didn't exit game yet but click [New Game] -> Delete all DontDestroyOnLoad
        GameObject storry002 = GameObject.FindGameObjectWithTag("Story_002");
        if (storry002)
        {
            Destroy(storry002.gameObject);
        }

        GameObject storry003 = GameObject.FindGameObjectWithTag("Story_003");
        if (storry003)
        {
            Destroy(storry003.gameObject);
        }

        GameObject storry004 = GameObject.FindGameObjectWithTag("Story_004");
        if (storry004)
        {
            Destroy(storry004.gameObject);
        }

        GameObject storry006 = GameObject.FindGameObjectWithTag("Story_006");
        if (storry006)
        {
            Destroy(storry006.gameObject);
        }

        GameObject storry007 = GameObject.FindGameObjectWithTag("Story_007");
        if (storry007)
        {
            Destroy(storry007.gameObject);
        }

        GameObject storry015 = GameObject.FindGameObjectWithTag("Story_015");
        if (storry015)
        {
            Destroy(storry015.gameObject);
        }

        GameObject storry016 = GameObject.FindGameObjectWithTag("Story_016");
        if (storry016)
        {
            Destroy(storry016.gameObject);
        }

        GameObject storry018 = GameObject.FindGameObjectWithTag("Story_018");
        if (storry018)
        {
            Destroy(storry018.gameObject);
        }

        Debug.Log("All things are deleted");
    }

}
