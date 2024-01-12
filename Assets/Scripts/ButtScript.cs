using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtScript : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void OnClickHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void OnClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnClickBack()
    {
       SceneManager.LoadScene("mainMenu");
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}