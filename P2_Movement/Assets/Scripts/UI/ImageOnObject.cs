using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageOnObject : MonoBehaviour
{
    [SerializeField]
    private Material imageMaterial;

    public Material ImageMaterial
    {
        get { return imageMaterial; }
        set { imageMaterial = value; }
    }
}
