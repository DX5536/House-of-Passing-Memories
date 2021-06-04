using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float initialSpeed;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float gravitySpeed;

    private CharacterController characterController;
    private Vector3 motion;

    private void Awake()
    {
        //holen component um zu manipulieren
        characterController = GetComponent<CharacterController>();

        initialSpeed = moveSpeed;
    }

    private void Update()
    {
        //Move with key-binding
        float horizontalInput = Input.GetAxis("Horizontal"); //Key: A & D
        //Vertical in this case is Z-Achse: going front or back
        float verticalInput = Input.GetAxis("Vertical"); //Key: W & S

        //wenn L.Shift -> rennen
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = runSpeed;
        }
        else //OG speed
        {
            moveSpeed = initialSpeed;
        }

        //We are in a 1st-Person game: Gravity ist Y-Achse; W/S is front aka Z-Achse.
        motion = new Vector3(horizontalInput, gravitySpeed, verticalInput);

        //Bewegung
        characterController.Move(motion * moveSpeed * Time.deltaTime);
    }
}
