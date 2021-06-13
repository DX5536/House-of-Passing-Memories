using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity;

    private Transform playerTransform;

    //pitch -> y-Achse Up&down
    private float pitch;

    //yaw -> x-Achse Left&right
    private float yaw;

    void Start()
    {
        playerTransform = transform.parent;
    }

    void Update()
    {
        //Mouse Bewegung -> Camera rotates after it
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        pitch -= mouseY;

        //clamp: Mathf (math function) is a property (was fur ein Wert, min Wert, max Wert)
        pitch = Mathf.Clamp(pitch, -45f, 45f); //clamp: Make sure value stays in a specific range -> cant go pass/below

        //only camera rotate up and down
        transform.localRotation = Quaternion.Euler(pitch, 0f, 0f); //You rotate yourself at x.axis -> x.Achse always 0

        yaw = mouseX;
        //clamp looking left&right
        yaw = Mathf.Clamp(yaw, -90f, 90f);

        //player rotate after mouse x-movement
        playerTransform.Rotate(0f, yaw, 0f); //You rotate yourself at y.axis -> y.Achse always 0

        //transform.rotation = Quaternion.Euler(0f, yaw, 0f);
    }
}
