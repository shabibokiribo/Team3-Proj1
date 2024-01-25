using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempDialogue : MonoBehaviour
{
    public string one = "Can't believe we lost to that loser.. I wouldn't have thought that coconut was a bomb.";
    public string two = "So, what now?";
    public string three = "Maybe we should start a podcast.";
    public string four = "I'd rather not, the lighting isn't great here.";
    public string five = "A podcast doesn't need lighting.";
    public string six = "Oh yeah, anyway, let's get out of here. Where even are we?";
    public string seven = "I believe we're in the afterlife, we should leave. This place sucks, we should find a Better Place *wink";

    public AudioClip oneClip;
    public AudioClip twoClip;
    public AudioClip threeClip;
    public AudioClip fourClip;
    public AudioClip fiveClip;   
    public AudioClip sixClip;
    public AudioClip sevenClip;

    public AudioSource source;


    public TMP_Text dialogue;
    public Image image;

    public Sprite mary;
    public Sprite gabriel;
    public Sprite floyd;

    public int index = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (index == 1)
        {
            source.clip = oneClip;
            image.sprite = gabriel;
            dialogue.text = one;

        }
        if (index == 2)
        {
            source.clip = twoClip;
            image.sprite = floyd;
            dialogue.text = two;

        }
        if (index == 3)
        {
            source.clip = twoClip;
            image.sprite = mary;
            dialogue.text = three;

        }
        if (index == 4)
        {
            source.clip = fourClip;
            image.sprite = floyd;
            dialogue.text = four;

        }
        if (index == 5)
        {
            source.clip = fiveClip;
            image.sprite = gabriel;
            dialogue.text = five;

        }
        if (index == 6)
        {
            source.clip = sixClip;
            image.sprite = floyd;
            dialogue.text = six;

        }
        if (index == 7)
        {
            source.clip = sevenClip;
            image.sprite = mary;
            dialogue.text = seven;

        }
        if (index == 8)
        {
            SceneManager.LoadScene("ShaniahScene");

        }
    }

    public void OnClickNext()
    {
        index++;
    }
}
