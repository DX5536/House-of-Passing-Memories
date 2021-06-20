using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ElevatorBasementLoadScene : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    [SerializeField]
    private string sceneBasement;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Elevator"))
        {
            if (other.CompareTag("ElevatorBasement"))
            {
                SceneManager.LoadScene(sceneBasement);
                Debug.Log("To the basement!");
            }

            //In Ground Floor: Collide with Elevator -> Go to Attic
            SceneManager.LoadScene(sceneName);
            Debug.Log("Should be teleported");

        }

        

        

    }
}
