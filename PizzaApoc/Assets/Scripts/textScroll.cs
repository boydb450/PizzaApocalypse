using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScroll : MonoBehaviour
{
    new float newPos;
    public Text txt;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        RectTransform assign_text_1RT = txt.GetComponent<RectTransform>();
        newPos = assign_text_1RT.anchoredPosition.y;
        newPos += speed;
        assign_text_1RT.anchoredPosition = new Vector3(0f, newPos, 0f);

    }
}
