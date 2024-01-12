using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloydScr : MonoBehaviour
{

    //Character Stats
    public int hp = 75; //max 75
    public int mp = 0; //max 50 , Increases +15 per turn

    public string charName = "Floyd";

    //MOVESET
    public string move1 = "Weak Strike"; // -5HP
    public string move2 = "Heal"; // Heals ONE selected character +25HP , -5MP
    public string move3 = "Water Attack"; // -15HP , -5MP
    public string specialMove = "Mass Heal"; // +25HP, -40MP

    public int potions = 3; //+10HP, +5MP

    //Turns
    public int movesLeft = 1; //subtracts when the complete an action

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
