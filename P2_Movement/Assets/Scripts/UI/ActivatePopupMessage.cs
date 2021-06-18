using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePopupMessage : MonoBehaviour
{
    //Assign the popup window
    [SerializeField]
    private GameObject popupObject;
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            popupObject.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Debug.Log("L.Mouse is clicked");
        }

        else
        {
            return;
        }
    }
}
