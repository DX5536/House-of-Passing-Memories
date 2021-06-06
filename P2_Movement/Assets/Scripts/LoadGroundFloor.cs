using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadGroundFloor : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene: " + scene.name + "was loaded sucessfully!");
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadSceneAdditive()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive); //Single (default): Del a scene, Add a scene; Additive (through LoadSceneMode.): Add a scene on top
    }
    public void UnLoadScene()
    {
        Scene scene = SceneManager.GetSceneByName(sceneName);
        //Idioten-Proof mit If-Statement
        if (scene.isLoaded)
        {
            SceneManager.UnloadSceneAsync(sceneName); //UnloadScene() wird Obsolete von Unity aka. delete in future version -> Can break codes in newer update :(
        }

    }
}
