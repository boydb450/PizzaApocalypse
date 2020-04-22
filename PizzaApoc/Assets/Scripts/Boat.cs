using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Boat : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Barrier;
    [SerializeField] GameObject NoReturn;
    AudioSource feetstampers;
    FirstPersonController playervariables;
    [SerializeField] Quaternion boatAngle;


    // Start is called before the first frame update
    void Start()
    {
        playervariables = Player.GetComponent<FirstPersonController>();
        feetstampers = Player.GetComponent<AudioSource>();
        NoReturn.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            feetstampers.enabled = false;
            gameObject.transform.parent = Player.transform;
            gameObject.transform.localRotation = boatAngle;
            gameObject.transform.localPosition = new Vector3(0.1f, -0.75f, 0.73f);
            playervariables.m_RunSpeed = 5;
            playervariables.m_UseHeadBob = false;
            playervariables.m_GravityMultiplier = 9999;
            Barrier.SetActive(false);
            NoReturn.SetActive(true);
        }
    }
}
