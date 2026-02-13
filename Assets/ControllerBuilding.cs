using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBuilding : MonoBehaviour
{
    [SerializeField] private List<GameObject> detal;
    [SerializeField] private int s = 0;

    private void Update()
    {
        if (detal[s].transform.childCount == 0)
        {
            s++;
            detal[s].SetActive(true);
        }
    }
}
