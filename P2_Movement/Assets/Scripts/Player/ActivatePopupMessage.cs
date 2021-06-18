using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePopupMessage : MonoBehaviour
{
    //Differenciate Selectable and non-Selectable through Tags
    [SerializeField]
    private string selectableTag; //now all GO with this tag can be highlight ^^

    //Special Object with special highlight
    [SerializeField]
    private string selectableSpecialTag;

    //Save current selection
    private Transform _selection;

    //Assign the popup window
    [SerializeField]
    private GameObject popupObject;
    
    public void Update()
    {
        //Assign a ray
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Object being hit
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //Selected object
            var selection = hit.transform;

            if (selection.CompareTag(selectableTag))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //var popupSelectedObject = GetComponentInParent<GameObject>();
                    //popupObject.transform.parent = popupSelectedObject.transform;

                    //popupObject.transform.GetChild(0).gameObject.SetActive(true);
                    popupObject.SetActive(true); //*this works for sure*

                    Cursor.lockState = CursorLockMode.Confined;
                    Debug.Log("L.Mouse is clicked");
                }
                

                _selection = selection;
            }

            else
            {
                popupObject.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
