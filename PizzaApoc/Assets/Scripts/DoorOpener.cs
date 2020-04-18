using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{

    public GameObject hinge;
    public GameObject door;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (hinge.transform.localRotation.y < 0.8f) { OpenDoor(); }

        }
    }

    private void OpenDoor()
    {
        print(hinge.transform.localRotation.y);
        hinge.transform.Rotate(new Vector3(0,30,0), 50 * Time.deltaTime);
        
    }

}
