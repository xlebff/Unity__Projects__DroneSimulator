using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Screw : MonoBehaviour
{
    [SerializeField] private string tagg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagg) 
        {
            other.enabled = false;
            gameObject.GetComponent<XRGrabInteractable>().enabled = false;
        }
    }
}
