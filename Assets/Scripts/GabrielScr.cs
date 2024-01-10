using NiceIO.Sysroot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GabrielScr : MonoBehaviour
{
    //Character Stats
    public int hp = 100; //max 100
    public int mp = 0; //max 50 , Increases +10 per turn

    public string charName = "Gabriel";

    //MOVESET
    public string move1 = "Slash"; // -15HP
    public string move2 = "Fire Slash"; // -20HP , -10MP
    public string specialMove = "Flury of Blows"; // -35HP, -40MP

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
