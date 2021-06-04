using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity;

    private Transform playerTransform;

    //pitch -> y-Achse
    private float pitch;

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

        //player rotate after mouse x-movement
        playerTransform.Rotate(0f, mouseX, 0f); //You rotate yourself at y.axis -> y.Achse always 0
    }
}
