using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtScript : MonoBehaviour
{
    public AudioSource audioSource;
    public void OnClickStart()
    {
        audioSource.Play();
        SceneManager.LoadScene("ShaniahScene");
    }

    public void OnClickHelp()
    {
        audioSource.Play();
        SceneManager.LoadScene("Help");
    }

    public void OnClickCredits()
    {
        audioSource.Play();
        SceneManager.LoadScene("Credits");
    }

    public void OnClickBack()
    {
        audioSource.Play();
        SceneManager.LoadScene("mainMenu");
    }

    public void OnClickQuit()
    {
        audioSource.Play();
        Application.Quit();
    }
}