using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Boat1 : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Barrier;
    AudioSource feetstampers;
    FirstPersonController playervariables;
    [SerializeField] Quaternion boatAngle;

    // Start is called before the first frame update
    void Start()
    {
        playervariables = Player.GetComponent<FirstPersonController>();
        feetstampers = Player.GetComponent<AudioSource>();

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            feetstampers.enabled = false;
            gameObject.transform.parent = Player.transform;
            gameObject.transform.localRotation = boatAngle;
            gameObject.transform.localPosition = new Vector3(0.1f, -0.66f, 0.4f);
            playervariables.m_RunSpeed = 15;
            playervariables.m_WalkSpeed = 10;
            playervariables.m_UseHeadBob = false;
            playervariables.m_GravityMultiplier = 9999;
            Barrier.SetActive(false);
        }
    }
}
