using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class FPSController : MonoBehaviour
{
    [SerializeField]
    private float walkingSpeed;
    [SerializeField]
    private float runningSpeed;
    [SerializeField]
    private float jumpSpeed;
    [SerializeField]
    private float gravity;

    [SerializeField]
    private Camera playerCamera;

    [SerializeField]
    private float lookSpeed;
    [SerializeField]
    private float lookXLimit;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;

    private float rotationX = 0;

    [SerializeField]
    private bool canMove;

    public bool CanMove
    {
        get { return canMove; }
        set { canMove = value; }
    }

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

        //Lock Cursor to center of screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; //see cursor or not
    }

    private void Update()
    {
        //Player grounded -> recalculated move direction based on position
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        //Left Shift to run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        //Cursor speed
        float cursorSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
        float cursorSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;

        //Player jumps
        float movementDirectionY = moveDirection.y;

        moveDirection = (forward * cursorSpeedX) + (right * cursorSpeedY);

        //Check if: JumpButton is pressed + Player moveable + Player is on the ground = all true
        if (Input.GetKey(KeyCode.Space) && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        //Apply gravity when player is NOT grounded aka. in the air
        if (!characterController.isGrounded)
        {
            //Player going back down aka. falling
            moveDirection.y -= gravity * Time.deltaTime;
        }

        //move Controller
        characterController.Move(moveDirection * Time.deltaTime);

        //if Player rotates -> Camera rotates with them
        if (canMove == true)
        {
            //Looking up and down
            rotationX -= Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit); //Limit on X-axis view angle

            //Looking left and right
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X")*lookSpeed,0); 
        }
    }
}
