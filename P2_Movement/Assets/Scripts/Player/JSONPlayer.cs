using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONPlayer : MonoBehaviour
{
    [SerializeField]
    private PlayerData playerData;

    public PlayerData PlayerData
    {
        //Get and set Value from saved playerData.cs 
        get { return playerData; }
        set { playerData = value; }
    }

    private void Start()
    {
        //Put Player in the saved position
        transform.position = PlayerData.position;
    }
}
