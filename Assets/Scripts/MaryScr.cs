using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaryScr : MonoBehaviour
{

    //Health Bar
    public HealthBar healthBar; //reference to Health Bar script

    // Mana Bar
    public ManaBar manaBar; //reference to Mana Bar script

    //Character Stats
    public int hp = 130; //max health is 130
    public int mp = 0; //max 40, Increases +10 per turn
    public int currentHealth; //store character's current health
    public int currentMana; //store character's current Mana 
    public string charName = "Mary";

    //MOVESET
    public string move1 = "Pound"; // -25HP
    public string move2 = "Sweeping Blow"; // Hits all enemies -15HP
    public string specialMove = "Rage"; // -5HP additional to all attacks, Take less 5 damage from hits, -40MP, Lasts 2 turns

    //Turns
    
    public int movesLeft = 1; //subtracts when the complete an action

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = hp; //set current health to max health at the start of the game
        healthBar.SetMaxHealth(hp); //set Mary's max health to hp (130)

       
        manaBar.SetMaxMana(40); //set Mary's max mana to 40

        manaBar.CurrentValue(0); //set Mana to 0 at the begining of the game

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) ) // TESTING: when the spacebar is pressed, take 20 damage 
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.M) ) // TESTING: when the spacebar is pressed, take 20 damage 
        {
            Debug.Log("The M key was pressed");
            GainMana(20); // TESTING: when 'M' is pressed, gain 20 mana
        }
    }

    public void TakeDamage(int damage) //take a certain amount of damage
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth); //update health bar to match the character's current health
    }

    public void GainMana(int mana) //gain a certain amount of mana  (should increase by 10 after each turn ends)
    {
        //currentMana += 10;

        currentMana -= mana;

        manaBar.SetMana(currentMana); //update mana bar to match the character's current mana status
    }

    //BUTTONS

    public void OnClickSelectMary()
    {
        Debug.Log("Mary is selected");
    }
}
