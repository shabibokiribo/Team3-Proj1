using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtScript : MonoBehaviour
{
    public AudioSource audioSource;
    private string sceneName;
    public bool sceneTransition = false;

    IEnumerator PlayAudioAndLoadScene()
    {
        // Play AudioSource
        audioSource.Play();
        // Set sceneTransition true
        sceneTransition = true;
        // Wait for half a second
        yield return new WaitForSeconds(0.5f);

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