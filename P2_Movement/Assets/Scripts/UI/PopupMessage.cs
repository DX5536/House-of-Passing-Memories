using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMessage : MonoBehaviour
{
    [SerializeField]
    private GameObject uI;

    PopupMessage popupMessage;
    GameObject popupManager;

    private void Start()
    {
        popupManager = GameObject.Find("PopupManager");
        popupMessage = popupManager.GetComponent<PopupMessage>();
    }


    //Folder of resources
    public Texture TakeInventoryCollection (string LoadCollectionsToInventory)
    {
        Texture loadedGO = Resources.Load("InventoryItems/" + LoadCollectionsToInventory, typeof(Texture)) as Texture;
        return loadedGO;
    }


    //open Popup
    public void Open(string inventoryStuffName, string message)
    {
        //UI de/activates depends on (state)
        uI.SetActive(!uI.activeSelf);

        //check consition of UI -> if UI is activated
        if (uI.activeSelf)
        {
            //if NullOrEmpty NOT true
            if (!string.IsNullOrEmpty(inventoryStuffName))
            {
                //set local Var
                var texture = TakeInventoryCollection(inventoryStuffName);
                RawImage rawImage = uI.gameObject.GetComponent<RawImage>();
                rawImage.texture = texture;
            }

            if (string.IsNullOrEmpty(message))
            {
                Text textObject = uI.gameObject.GetComponentInChildren<Text>();
                textObject.text = message;
            }
            popupMessage.Open("NameofTexture", "This is some Text");
            Time.timeScale = 0f;
        }
    }

    //close Popup upon clicking OK
    public void Close()
    {
        uI.SetActive(!uI.activeSelf);

        if (!uI.activeSelf)
        {
            Time.timeScale = 1f;
        }
    }
}
