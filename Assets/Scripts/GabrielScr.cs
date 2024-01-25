//using NiceIO.Sysroot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GabrielScr : MonoBehaviour
{

 //Health Bar
    public HealthBar healthBar; //reference to Health Bar script

    // Mana Bar
    public ManaBar manaBar; //reference to Mana Bar script

    //Character Stats
    public int hp = 100; //max 100
    public int mp = 0; //max 50 , Increases +10 per turn
    public int currentHealth; //store character's current health
    public int currentMana; //store character's current Mana 

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
        currentHealth = hp; //set current health to max health at the start of the game
        healthBar.SetMaxHealth(hp); //set Gabriel's max health to hp (100)

       
        manaBar.SetMaxMana(50); //set Gabriel's max mana to 50

        manaBar.CurrentValue(0); //set Mana to 0 at the begining of the game
    }

// Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage) //take a certain amount of damage
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth); //update health bar to match the character's current health
    }

    public void GainMana(int mana) //gain a certain amount of mana  (should increase by 10 after each turn ends)
    {
        //currentMana += 10;

        currentMana += mana;

        manaBar.SetMana(currentMana); //update mana bar to match the character's current mana status
    }


}
