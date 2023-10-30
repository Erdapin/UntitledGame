using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IInteractable
{
    private Material material;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        Debug.Log(material);
    }

    private void ToggleColors()
    {

        material.color = Random.ColorHSV();
    }


    public void Interact()
    {
        ToggleColors();
    }
}
