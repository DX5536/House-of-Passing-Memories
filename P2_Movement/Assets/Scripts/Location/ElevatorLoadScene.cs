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
    private string basement0SceneName;

    [SerializeField]
    private string basement1SceneName;

    [SerializeField]
    private string basement2SceneName;

    [SerializeField]
    private string basement3SceneName;

    [SerializeField]
    private string basement4SceneName;

    [SerializeField]
    private string basement5SceneName;

    [SerializeField]
    private string gameCompleteSceneName;


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
            GameObject savedGFValue = GameObject.FindWithTag("GFSpawnValue");
            SaveValueForGFSpawner saveValueForGFSpawner = savedGFValue.GetComponent<SaveValueForGFSpawner>();

            saveValueForGFSpawner.SaveValueForSpawn = 0;

            SceneManager.LoadScene(2);
        }

        else if (other.CompareTag("ElevatorFromBasementToGroundfloor"))
        {
            GameObject savedGFValue = GameObject.FindWithTag("GFSpawnValue");
            SaveValueForGFSpawner saveValueForGFSpawner = savedGFValue.GetComponent<SaveValueForGFSpawner>();

            saveValueForGFSpawner.SaveValueForSpawn = 1;

            SceneManager.LoadScene(2);
        }

        else if (other.CompareTag("ElevatorToBasement"))
        {
            SceneManager.LoadScene(basement0SceneName);
        }

        //Judgement Quiz -> if wrong ^
        else if (other.CompareTag("RightAnswer0"))
        {
            SceneManager.LoadScene(basement1SceneName);
        }

        else if (other.CompareTag("RightAnswer1"))
        {
            SceneManager.LoadScene(basement2SceneName);
        }

        else if (other.CompareTag("RightAnswer2"))
        {
            SceneManager.LoadScene(basement3SceneName);
        }

        else if (other.CompareTag("RightAnswer3"))
        {
            SceneManager.LoadScene(basement4SceneName);
        }

        else if (other.CompareTag("RightAnswer4"))
        {
            SceneManager.LoadScene(basement5SceneName);
        }

        else if (other.CompareTag("RightAnswer5"))
        {
            SceneManager.LoadScene(gameCompleteSceneName);
        }
    }

}
