using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isAttacked;

    //Health Bar
    public HealthBar healthBar; //reference to Health Bar script

    // Mana Bar
    public ManaBar manaBar; //reference to Mana Bar script

    public UI gm;

    //enemy moves
    public string move1;
    public string move2;
    public string special;

    //enemy hp and mp
    public int hp;
    public int mp;
    public int currentHealth; //store character's current health
    public int currentMana; //store character's current Mana 

    public string enemyName;

    public int movesLeft = 1;



    // Start is called before the first frame update
    void Start()
    {

        healthBar.SetMaxHealth(hp); //set Gabriel's max health to hp (100)


    }

    // Update is called once per frame
    void Update()
    {
        if (gm.sceneName == "ShaniahScene" && gm.currentWave == 1) //Angels
        {
            enemyName = "Angel";

            move1 = "Angel Main Attack"; //-10HP to one character
            move2 = "Angel Heavy Attack"; //-20HP to one character
            special = "Angel Beam"; //-25 HP to all of party, -40MP

            hp = 40;
            mp = 40;

            currentHealth = hp;

            manaBar.SetMaxMana(40); //set Angel's max mana to 40

            manaBar.CurrentValue(0); //set Mana to 0 at the begining of the game
        }

        if (gm.sceneName == "ShaniahScene" && gm.currentWave == 2) //Cherubs
        {
            enemyName = "Cherub";

            move1 = "Cherub Main Attack"; //-5HP to one character
            move2 = "Cherub Heavy Attack"; //-10HP to one character
            special = "Cherub's Arrows"; //-15 HP to all of party, -40MP

            hp = 40;
            mp = 40;

            currentHealth = hp;

            manaBar.SetMaxMana(40); //set Angel's max mana to 40

            manaBar.CurrentValue(0); //set Mana to 0 at the begining of the game
        }


        //if gm.currentRound
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
}
