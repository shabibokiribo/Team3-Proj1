using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterProfileScr : MonoBehaviour
{
    // gameObjects
    public GameObject gabrielProfile;
    public GameObject floydProfile;
    public GameObject maryProfile;

    // variables
    private bool gabriel = false;
    private bool floyd = false;
    private bool mary = false;

    // Start is called before the first frame update
    void Start()
    {
        gabrielProfile.SetActive(false);
        floydProfile.SetActive(false);
        maryProfile.SetActive(false);
        gabriel = false;
        floyd = false; 
        mary = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gabrielPFOnClick()
    {
        if (gabriel == true)
        {
            gabrielProfile.SetActive(false);
            gabriel = false;
        }
        else if (mary == false)
        {
            gabrielProfile.SetActive(true);
            gabriel = true;
        }
    }

    public void maryPFOnClick()
    {
        if (mary == true)
        {
            maryProfile.SetActive(false);
            mary = false;
        }
        else if (mary == false)
        {
            maryProfile.SetActive(true);
            mary = true;
        }
        
    }

    public void floydPFOnClick()
    {
        if (floyd == true)
        {
            floydProfile.SetActive(false);
            floyd = false;
        }
        else if (floyd == false)
        {
            floydProfile.SetActive(true);
            floyd = true;
        }
    }
}
