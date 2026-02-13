using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Screwdriver : MonoBehaviour
{
    [SerializeField] private Transform parent;
    private bool cheker = false;
    private GameObject screw;
    private float s = 0;

    private void Update()
    {
        if(cheker)
        {
            transform.Rotate(new Vector3(180,0,0), 1);
            parent.position = Vector3.Lerp(transform.position, new Vector3(parent.position.x, parent.position.y, s), 0.5f * Time.deltaTime);
        
        }
        if(parent.position.z >= s - 0.03f)
        {
            cheker = false;
            screw.transform.parent = null;
            GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Screw>())
        {        
            other.GetComponent<Collider>().enabled = false;
            GetComponentInParent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            parent.position = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z - 0.5f);
            Debug.Log(parent);
            s = parent.position.y + 0.1f;
            cheker = true;
            screw = other.gameObject;
            other.gameObject.transform.parent = gameObject.transform;
        }
    }
}
