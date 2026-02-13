using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matrial : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private float count = 1;
    private bool s = true;
    private bool ss = true;
    private void Start()
    {
        StartCoroutine(Timer());
    }
    private void Update()
    {
        material.color = new Color(count, 0, 0, 0.50F);
        if(count <= 0.1f)
        {
            ss = false;
        }
        if (count >= 0.9f)
        {
            ss = true;
        }
    }
    IEnumerator Timer()
    {
        while (s)
        {
            s=false;
            if (ss)
            {
                count -= 0.01f;
            }
            if (!ss)
            {
                count += 0.01f;
            }
            yield return new WaitForSeconds(0.02f);
            s = true;
        }
    }
}
