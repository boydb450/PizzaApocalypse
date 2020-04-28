using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGetta : MonoBehaviour
{
    public bool boxy;
    public Quaternion baoal;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.transform.parent = other.transform;
            gameObject.transform.localPosition = new Vector3(0, 0, .28f);
            gameObject.transform.localRotation = baoal;
            boxy = true;
        }
    }
}
