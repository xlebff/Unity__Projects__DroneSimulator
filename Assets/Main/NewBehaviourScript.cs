using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("444"))
        {
            other.transform.localScale = new Vector3(0.07438999f, 0.09564999f, 0.09564999f);
        }
    }
}
