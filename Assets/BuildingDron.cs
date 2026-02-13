using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
//[RequireComponent(typeof(XRGrabInteractable))]
public class BuildingDron : MonoBehaviour
{
    [SerializeField] private string nameDetaling;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == nameDetaling)
        {
            GetComponent<XRGrabInteractable>().enabled = false;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            GetComponent<Collider>().isTrigger = true;

            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
            Destroy(other.gameObject);
            gameObject.isStatic = true;
        }
    }
}
