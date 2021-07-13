using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    [SerializeField]
    private GameObject whichLightBulb;

    [SerializeField]
    private string whichLightBulbManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TurnOnLightBulb();
            Debug.Log("Kachink!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TurnOffLightBulb();
        Debug.Log("Kachao!");
    }

    void TurnOnLightBulb()
    {
        //Find the lightbulb
        GameObject currentLightBulb = GameObject.Find(whichLightBulb.name);

        //Get Comp LightAutomatic-Comp and save in local var
        LightAutomatic lightAutomatic = currentLightBulb.GetComponent<LightAutomatic>();

        //Check if the chosen Light is the same as the one with the chosen Collider Box -> If yes, turn on
        if (lightAutomatic.LightBulbLocationName == whichLightBulbManager)
        {
            //The GameObject with lightAutomatic-Script to be turn on
            lightAutomatic.LightBulb.enabled = true;
        }
    }

    void TurnOffLightBulb()
    {
        //Find the lightbulb
        GameObject currentLightBulb = GameObject.Find(whichLightBulb.name);
        //Get Comp LightAutomatic-Comp and save in local var
        LightAutomatic lightAutomatic = currentLightBulb.GetComponent<LightAutomatic>();

        //The GameObject with lightAutomatic-Script to be turn off
        lightAutomatic.LightBulb.enabled = false;
    }
}
