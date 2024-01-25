using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtScript : MonoBehaviour
{
    public AudioSource audioSource;
    private string sceneName;
    public Animator transition;
    public float transitionTime = 1f;


    IEnumerator PlayAudioAndLoadScene()
    {
        // Play AudioSource
        audioSource.Play();
        // Set trigger
        transition.SetTrigger("Start");
        // Wait for half a second
        yield return new WaitForSeconds(transitionTime);

        // Load your scene
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickStart()
    {
        sceneName = "ShaniahScene";
        StartCoroutine(PlayAudioAndLoadScene());
    }

    public void OnClickHelp()
    {
        sceneName = "Help";
        StartCoroutine(PlayAudioAndLoadScene());
    }

    public void OnClickCredits()
    {
        sceneName = "Credits";
        StartCoroutine(PlayAudioAndLoadScene());
    }

    public void OnClickBack()
    {
        sceneName = "mainMenu";
        StartCoroutine(PlayAudioAndLoadScene());
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}