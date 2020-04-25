using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{


    public void controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void goBack()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
