using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameAllReset : MonoBehaviour
{
    private void PrefReset()
    {
        PlayerPrefs.DeleteAll();
    }

}
