using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameAllReset : MonoBehaviour
{
    public void PrefReset()
    {
        PlayerPrefs.DeleteAll();
    }

}
