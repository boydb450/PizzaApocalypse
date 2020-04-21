using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBeam : MonoBehaviour
{

    MeshRenderer lightSight;

    // Start is called before the first frame update
    void Start()
    {
       lightSight = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightSight.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightSight.enabled = true;
        }
    }

}
