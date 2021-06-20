using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Update is called once per frame
    void Update()
    {
        //De-selection -> GO goes back to defaultMaterial
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial; //set material to default material
            _selection = null;
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
                if(selectionRenderer != null )
                {
                    //if true -> set default Material to highlightMaterial
                    selectionRenderer.material = highlightMaterial;
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
                }

                _selection = selection;
            }
        }
    }
}
