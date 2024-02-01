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
    public string seven = "I believe we're in the afterlife, we should leave. This place sucks, we should find a Better Place!";

    public AudioClip oneClip;
    public AudioClip twoClip;
    public AudioClip threeClip;
    public AudioClip fourClip;
    public AudioClip fiveClip;   
    public AudioClip sixClip;
    public AudioClip sevenClip;

    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    public AudioSource source4;
    public AudioSource source5;
    public AudioSource source6;
    public AudioSource source7;


    public TMP_Text dialogue;
    public Image image;

    public Sprite mary;
    public Sprite gabriel;
    public Sprite floyd;

    public int index;

    public bool check = false;


    // Start is called before the first frame update
    void Start()
    {
        index = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //ControlAudio();
    }

    public void OnClickNext()
    {
        index++;
        ControlAudio();
        //Invoke("ResetCheck", 1f);
        //check = true;
    }

    public void ControlAudio() 
    {
        
            if (index == 1)
            {
                source1.clip = oneClip;
                image.sprite = gabriel;
                dialogue.text = one;
                source1.Play();

            }
            if (index == 2)
            {
                source2.clip = twoClip;
                image.sprite = floyd;
                dialogue.text = two;
                source2.Play();

            }
            if (index == 3)
            {
                source3.clip = threeClip;
                image.sprite = mary;
                dialogue.text = three;
                source3.Play();

            }
            if (index == 4)
            {
                source4.clip = fourClip;
                image.sprite = floyd;
                dialogue.text = four;
                source4.Play();

            }
            if (index == 5)
            {
                source5.clip = fiveClip;
                image.sprite = gabriel;
                dialogue.text = five;
                source5.Play();

            }
            if (index == 6)
            {
                source6.clip = sixClip;
                image.sprite = floyd;
                dialogue.text = six;
                source6.Play();

            }
            if (index == 7)
            {
                source7.clip = sevenClip;
                image.sprite = mary;
                dialogue.text = seven;
                source7.Play();

            }
            if (index == 8)
            {
                Invoke("LoadIt", .5f);

            }
        
    }

    public void ResetCheck()
    {
        check = false;
    }

    public void LoadIt()
    {
        SceneManager.LoadScene("ShaniahScene");
    }
}
