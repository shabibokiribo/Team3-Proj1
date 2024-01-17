using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelEnemy : MonoBehaviour
{
  public FloydScr floyd; //reference to Floyd script


  public bool isAttacked; //true if angel is attacked 



  //Health Bar
    public HealthBar healthBar; //reference to Health Bar script

    // Mana Bar
    public ManaBar manaBar; //reference to Mana Bar script

    //Character Stats
    public int hp = 50; //max health is 50
    public int mp = 0; //max 50, Increases +10 per turn
    public int currentHealth; //store character's current health
    public int currentMana; //store character's current Mana 
    public string enemyName = "Angel";

    //MOVESET
    public string move1 = "Holy Hit"; // -15HP
    public string move2 = "Heavenly Light"; // Hits all enemies -15HP
    public string specialMove = "Sunbeam"; // Hits one enemy for -45HP -50MP

    //Turns
    
    public int movesLeft = 1; //subtracts when the complete an action

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = hp; //set current health to max health at the start of the game
        healthBar.SetMaxHealth(hp); //set Angel's max health to hp (50)

       
        manaBar.SetMaxMana(50); //set Angel's max mana to 50

        manaBar.CurrentValue(0); //set Mana to 0 at the begining of the game

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    void TakeDamage(int damage) //take a certain amount of damage
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth); //update health bar to match the character's current health
    }

    void GainMana() //gain a certain amount of mana  (should increase by 10 after each turn ends)
    {
        currentMana += 10;

        manaBar.SetMana(currentMana); //update mana bar to match the character's current mana status
    }
}
