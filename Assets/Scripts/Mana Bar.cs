using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider slidey;
    
    public void SetMaxMana(int mana)
    {
        slidey.maxValue = mana; 
        slidey.value = mana; 

    }

    public void SetMana(int mana)
    {
        slidey.value = mana; // adjust the value of the 
       
    }
}