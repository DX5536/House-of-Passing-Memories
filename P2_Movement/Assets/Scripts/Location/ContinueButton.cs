using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    private int sceneToContinue;

    private bool elevatorDoorToContinue;

    private bool has002ActivatedToContinue;
    private bool has003ActivatedToContinue;
    private bool has004ActivatedToContinue;
    private bool has006ActivatedToContinue;
    private bool has007ActivatedToContinue;
    private bool has015ActivatedToContinue;
    private bool has016ActivatedToContinue;
    private bool has018ActivatedToContinue;

    [SerializeField]
    private GameObject valueForSpawnPrefab;

    [SerializeField]
    private GameObject valueForElevatorPrefab;

    [SerializeField]
    private GameObject valueFor002Prefab;

    [SerializeField]
    private GameObject valueFor003Prefab;

    [SerializeField]
    private GameObject valueFor004Prefab;

    [SerializeField]
    private GameObject valueFor006Prefab;

    [SerializeField]
    private GameObject valueFor007Prefab;

    [SerializeField]
    private GameObject valueFor015Prefab;

    [SerializeField]
    private GameObject valueFor016Prefab;

    [SerializeField]
    private GameObject valueFor018Prefab;

    //Public cuz of Continue-Button in Menu
    public void ContinueGameButtonScene()
    {
        //Load the savedScene from BackToMenu.cs
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        //Idiot-Proof
        if (sceneToContinue != 0)
        {
            //Load scene
            SceneManager.LoadScene(sceneToContinue);

            //Make sure GF value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("GFSpawnValue");
            if (objs.Length < 1)
            {
                Instantiate(valueForSpawnPrefab);
            }

        }

        //If there is no SavedScene -> Doesnt work
        else
        {
            return;
        }

    }

    public void ContinueGameButtonElevator()
    {
        elevatorDoorToContinue = PlayerPrefs.GetInt("SavedElevatorDoor") == 1 ? true : false;

        //Idiot-Proof
        if (elevatorDoorToContinue == true)
        {
            //Make sure elevator value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("ElevatorDoorDestroyedValue");
            if (objs.Length < 1)
            {
                Instantiate(valueForElevatorPrefab);
            }

            GameObject loadElevatorValue = GameObject.FindGameObjectWithTag("ElevatorDoorDestroyedValue");

            HasElevatorDoorDestroyedBefore hasElevatorDoorDestroyedBefore = loadElevatorValue.GetComponent<HasElevatorDoorDestroyedBefore>();
            hasElevatorDoorDestroyedBefore.IsElevatorDestroyed = true;
        }

        //If there is no SavedScene -> Doesnt work
        else
        {
            return;
        }
    }

    public void ContinueGameButtonAttic()
    {
        ContinueGameButton002();
        ContinueGameButton003();
        ContinueGameButton004();
        ContinueGameButton006();
    }

    public void ContinueGameButtonGroundFloor()
    {
        ContinueGameButton007();
    }

    public void ContinueGameButtonBasement()
    {
        ContinueGameButton015();
        ContinueGameButton016();
        ContinueGameButton018();
    }

    private void ContinueGameButton002()
    {
        has002ActivatedToContinue = PlayerPrefs.GetInt("Saved002Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has002ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_002");
            if (objs.Length < 1)
            {
                Instantiate(valueFor002Prefab);
            }

            GameObject load002Value = GameObject.FindGameObjectWithTag("Story_002");

            HasStoryColliderActivated hasStoryColliderActivated = load002Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

    private void ContinueGameButton003()
    {
        has003ActivatedToContinue = PlayerPrefs.GetInt("Saved003Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has003ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_003");
            if (objs.Length < 1)
            {
                Instantiate(valueFor003Prefab);
            }

            GameObject load003Value = GameObject.FindGameObjectWithTag("Story_003");

            HasStoryColliderActivated hasStoryColliderActivated = load003Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

    private void ContinueGameButton004()
    {
        has004ActivatedToContinue = PlayerPrefs.GetInt("Saved004Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has004ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_004");
            if (objs.Length < 1)
            {
                Instantiate(valueFor004Prefab);
            }

            GameObject load004Value = GameObject.FindGameObjectWithTag("Story_004");

            HasStoryColliderActivated hasStoryColliderActivated = load004Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

    private void ContinueGameButton006()
    {
        has006ActivatedToContinue = PlayerPrefs.GetInt("Saved006Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has006ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_006");
            if (objs.Length < 1)
            {
                Instantiate(valueFor006Prefab);
            }

            GameObject load006Value = GameObject.FindGameObjectWithTag("Story_006");

            HasStoryColliderActivated hasStoryColliderActivated = load006Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

    private void ContinueGameButton007()
    {
        has007ActivatedToContinue = PlayerPrefs.GetInt("Saved007Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has007ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_007");
            if (objs.Length < 1)
            {
                Instantiate(valueFor007Prefab);
            }

            GameObject load007Value = GameObject.FindGameObjectWithTag("Story_007");

            HasStoryColliderActivated hasStoryColliderActivated = load007Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

    private void ContinueGameButton015()
    {
        has015ActivatedToContinue = PlayerPrefs.GetInt("Saved015Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has015ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_015");
            if (objs.Length < 1)
            {
                Instantiate(valueFor015Prefab);
            }

            GameObject load015Value = GameObject.FindGameObjectWithTag("Story_015");

            HasStoryColliderActivated hasStoryColliderActivated = load015Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

    private void ContinueGameButton016()
    {
        has016ActivatedToContinue = PlayerPrefs.GetInt("Saved016Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has016ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_016");
            if (objs.Length < 1)
            {
                Instantiate(valueFor016Prefab);
            }

            GameObject load016Value = GameObject.FindGameObjectWithTag("Story_016");

            HasStoryColliderActivated hasStoryColliderActivated = load016Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

    private void ContinueGameButton018()
    {
        has018ActivatedToContinue = PlayerPrefs.GetInt("Saved018Voice") == 1 ? true : false;

        //Idiot-Proof
        if (has018ActivatedToContinue == true)
        {
            //Make sure story value is there so no spawning Error
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Story_018");
            if (objs.Length < 1)
            {
                Instantiate(valueFor018Prefab);
            }

            GameObject load018Value = GameObject.FindGameObjectWithTag("Story_018");

            HasStoryColliderActivated hasStoryColliderActivated = load018Value.GetComponent<HasStoryColliderActivated>();
            hasStoryColliderActivated.IsStoryVoicePlayed = true;
        }

        //If there is no Saved -> Doesnt work
        else
        {
            return;
        }
    }

}
