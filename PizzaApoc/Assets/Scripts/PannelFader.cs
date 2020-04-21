using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelFader : MonoBehaviour
{
    private bool fader = false;
    public float duration = 0.4f;
    CanvasGroup tehCanvace;

    // Start is called before the first frame update
    void Start()
    {
        tehCanvace = GetComponent<CanvasGroup>();
    }

    public void FadeIn()
    {
        fader = true;
        StartCoroutine(Dofade(tehCanvace, tehCanvace.alpha, 0));

    }

    public IEnumerator Dofade(CanvasGroup canvasGroup, float start, float end)
    {
        float counter = 0f;

        while(counter < duration)
        {
            counter += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, counter / duration);
            yield return null;
        }
    }

}
