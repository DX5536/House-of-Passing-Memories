using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ElevatorLoadScene : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Elevator"))
        {
            //In Ground Floor: Collide with Elevator -> Go to Attic
            SceneManager.LoadScene(sceneName);
            Debug.Log("Should be teleported");
        }

    }
}
