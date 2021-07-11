using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroContinue : MonoBehaviour
{
    public void IntroContinueButton()
    {
        //Load Intro
        SceneManager.LoadScene(1);
    }
}
