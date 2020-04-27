using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition1 : MonoBehaviour
{
    bool clickersd = false;
    public GameObject Ui;
    public float duration = 0.4f;
    public CanvasGroup tehCanvace;
    public AudioSource sauce;

    public GameObject textOne,textTwo;

    [SerializeField]
    string Target;

    private void Awake()
    {
        textTwo.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (clickersd == false)
        {
            if (other.CompareTag("Player"))
            {
                clickersd = true;         
                sauce.Play();
                StartCoroutine(Dofade(tehCanvace, tehCanvace.alpha, 0));
            }
        }
    }

    public IEnumerator Dofade(CanvasGroup canvasGroup, float start, float end)
    {
        float counter = 0f;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            canvasGroup.alpha = counter;
            yield return null;
        }
        textOne.SetActive(false);
        textTwo.SetActive(true);

    }

}
