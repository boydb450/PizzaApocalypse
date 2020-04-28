using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{

    public GameObject hinge;
    public GameObject door;
    public GameObject box;
    BoxGetta refScript;

    private void Start()
    {
        refScript = box.GetComponent<BoxGetta>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") & refScript.boxy)
        {
            if (hinge.transform.localRotation.y < 0.8f) { OpenDoor(); }

        }
    }

    private void OpenDoor()
    {
        hinge.transform.Rotate(new Vector3(0,30,0), 60 * Time.deltaTime);
        
    }

}
