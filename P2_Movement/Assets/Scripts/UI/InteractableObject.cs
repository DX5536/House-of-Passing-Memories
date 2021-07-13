using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI descriptionText;

    public TextMeshProUGUI DescriptionText
    {
        get { return descriptionText; }
        set { descriptionText = value; }
    }
}