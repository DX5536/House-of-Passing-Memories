using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void StartGameButton()
    {
        //Load Attic
        SceneManager.LoadScene(2);
    }
}
