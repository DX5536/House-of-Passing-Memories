using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    //Differenciate Selectable and non-Selectable through Tags
    [SerializeField]
    private string selectableTag; //now all GO with this tag can be highlight ^^

    //Special Object with special highlight
    [SerializeField]
    private string selectableSpecialTag;

    //Assign highlightMaterial
    [SerializeField]
    private Material highlightMaterial;

    //Assign highlightSpecialMaterial
    [SerializeField]
    private Material highlightSpecialMaterial;
    
    [SerializeField]
    private Material defaultMaterial;

    //Save current selection
    private Transform _selection;

    private bool isObjectHighlighted;

    // Update is called once per frame
    void Update()
    {
        HighlightSelectedObject();

        if (isObjectHighlighted == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PopupMessage();
            }
        }
        else
        {
            Destroy(spawnedPopup);
        }
    }

    void HighlightSelectedObject()
    {
        //De-selection -> GO goes back to defaultMaterial
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial; //set material to default material
            _selection = null;

            isObjectHighlighted = false;
        }

        //Assign a ray
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Object being hit
        RaycastHit hit;

        //check if Ray hit the object -> Selection
        if (Physics.Raycast(ray, out hit, 1.3f)) ////Ray-length = Arm-length
        {
            //Selected object
            var selection = hit.transform;

            //Check through tag if GO can be highlighted
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();

                //check if selected Object doesn't NOT have a renderer
                if (selectionRenderer != null)
                {
                    //if true -> set default Material to highlightMaterial
                    selectionRenderer.material = highlightMaterial;

                    isObjectHighlighted = true;
                }

                _selection = selection;
            }

            //check through Tags if it's specialObject
            else if (selection.CompareTag(selectableSpecialTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();

                //check if selected Object doesn't NOT have a renderer
                if (selectionRenderer != null)
                {
                    //if true -> set default Material to highlightSpecialMaterial
                    selectionRenderer.material = highlightSpecialMaterial;

                    isObjectHighlighted = true;
                }

                _selection = selection;
            }

            
        }
    }

    [SerializeField]
    private GameObject prefabPopup;
    private GameObject spawnedPopup;

    
    private GameObject hittedObject;

    private GameObject textMeshChild;


    void PopupMessage()
    {
        if (spawnedPopup == null)
        { 
            hittedObject = _selection.gameObject;

            //Debug.Log("I click on " + _selection.name); //Check which Object is being click on
            //Debug.Log("I 2 click on " + hittedObject.name);

            //Spawn the popup Box
            spawnedPopup = Instantiate(prefabPopup);

            //Take prefabObject -> put in selectedObject => Not what we wanted D;
            //_selection.GetComponent<InteractableObject>().descriptionText.text = spawnedPopup.GetComponent<TextMeshProUGUI>().text;

            //Take selectedObject -> put in Prefab => FUCK YES!!!!! But only if TextUI is in PopupMessage -> Not Child's Text ;(
            //spawnedPopup.GetComponent<TextMeshProUGUI>().text = _selection.GetComponent<InteractableObject>().descriptionText.text; //*this works great*

            //Save selectedObject-Text to Parent-Text in local Variable
            //string textMeshCompOfParent = spawnedPopup.GetComponent<TextMeshProUGUI>().text = _selection.GetComponent<InteractableObject>().descriptionText.text;

            //Find the Text-GameObjectChild in spawnedPopup (prefab)
            textMeshChild = spawnedPopup.transform.Find("Text").gameObject;

            //Get TMP-Component of Text-Child
            //string textMeshCompOfChild = textMeshChild.GetComponentInChildren<TextMeshProUGUI>().text;

            //Assign Parent's Text to Child's Text
            //textMeshChild.GetComponentInChildren<TextMeshProUGUI>().text = textMeshCompOfParent;

            //Assign selectedObject-Text to Child-text directly *this is the one ;v;
            textMeshChild.GetComponentInChildren<TextMeshProUGUI>().text = _selection.GetComponent<InteractableObject>().descriptionText.text;

            //Debug.Log("PrefabObject's Text: " + spawnedPopup.GetComponent<TextMeshProUGUI>().text);
            //Debug.Log("PrefabObject's Child's Text: " + textMeshChild.GetComponentInChildren<TextMeshProUGUI>().text);
            //Debug.Log("PrefabObject's Parent's Text: " + spawnedPopup.GetComponentInParent<TextMeshProUGUI>().text);
            //Debug.Log("SelectedObject's Text: " + _selection.GetComponent<InteractableObject>().descriptionText.text); //later part works as intended -> TMP 

        }

    }
}
