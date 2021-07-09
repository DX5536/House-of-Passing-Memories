using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ElevatorLoadScene : MonoBehaviour
{
    [SerializeField]
    private string atticSceneName;

    [SerializeField]
    private string groundfloorSceneName;

    [SerializeField]
    private string basementSceneName;

    //SpawnPoint will have to get access to the saved value to dertimine which spawn point to use in GF
    private SaveValueForGFSpawner value;

    private int localValue;

    private void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ElevatorToAttic"))
        {
            //In Ground Floor: Collide with Elevator -> Go to Attic
            SceneManager.LoadScene(atticSceneName);
            

            //Debug.Log("Should be teleported");
        }

        else if (other.CompareTag("ElevatorFromAtticToGroundfloor"))
        {
            GameObject savedGFValue = GameObject.Find("SaveValueForSpawn");
            SaveValueForGFSpawner saveValueForGFSpawner = savedGFValue.GetComponent<SaveValueForGFSpawner>();

            saveValueForGFSpawner.saveValueForSpawn = 0;

            SceneManager.LoadScene(2);
        }

        else if (other.CompareTag("ElevatorFromBasementToGroundfloor"))
        {
            GameObject savedGFValue = GameObject.Find("SaveValueForSpawn");
            SaveValueForGFSpawner saveValueForGFSpawner = savedGFValue.GetComponent<SaveValueForGFSpawner>();

            saveValueForGFSpawner.saveValueForSpawn = 1;

            SceneManager.LoadScene(2);
        }

        else if (other.CompareTag("ElevatorToBasement"))
        {
            SceneManager.LoadScene(basementSceneName);
        }
    }

}
