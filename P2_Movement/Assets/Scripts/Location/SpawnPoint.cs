using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;

    [SerializeField]
    private GameObject spawnLocation;

    [SerializeField]
    private GameObject[] spawnLocations;

    private GameObject player;

    private Vector3 respawnLocation;

    private SaveValueForGFSpawner whichSpawnLocationToUse;

    private Scene currentScene;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    private void Start()
    {
        player = playerPrefab;

        spawnLocation = GameObject.FindGameObjectWithTag("SpawnPoint");

        respawnLocation = player.transform.position;

        string sceneName = currentScene.name;

        //If not GroundFloor -> Spawn from 1 point
        if(sceneName != "02_GroundFloor")
        {
            SpawnPlayer();
        }
        //If GroundFloor -> Spawn from 2 points depends on SavedValue
        else
        {
            SpawnPlayerInGroundFloor();
        }
        
    }

    private void SpawnPlayer()
    {
        GameObject.Instantiate(player, spawnLocation.transform.position, Quaternion.identity);
    }

    private void SpawnPlayerInGroundFloor()
    {
        GameObject savedGFValue = GameObject.Find("SaveValueForSpawn");
        SaveValueForGFSpawner saveValueForGFSpawner = savedGFValue.GetComponent<SaveValueForGFSpawner>();

        int spawn = saveValueForGFSpawner.saveValueForSpawn;

        // if spawn is a number, it should work
        GameObject.Instantiate(player, spawnLocations[spawn].transform.localPosition, Quaternion.identity);
    }
}
