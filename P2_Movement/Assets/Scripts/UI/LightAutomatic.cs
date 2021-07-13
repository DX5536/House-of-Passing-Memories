using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LightAutomatic : MonoBehaviour
{
    [SerializeField]
    private string lightBulbLocationName;
    [SerializeField]
    private Light lightBulb;

    public string LightBulbLocationName
    {
        get { return lightBulbLocationName; }
        set { lightBulbLocationName = value; }
    }

    public Light LightBulb
    {
        get { return lightBulb; }
        set { lightBulb = value; }
    }
}
