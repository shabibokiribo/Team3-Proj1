using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    //Canvases
    public Canvas selection;
    public Canvas moves;
    public Canvas items;
    public Canvas special;

    //Text
    public TMP_Text move1Text;
    public TMP_Text move2Text;
    public TMP_Text move3Text;

    public TMP_Text specialText;
    public TMP_Text potionText;

    public TMP_Text specialErrorText;
    public TMP_Text moveErrorText;
    public TMP_Text potionErrorText;

    public TMP_Text hpText;
    public TMP_Text mpText;

    //SCRIPTS
    public MaryScr mScript;
    public FloydScr fScript;
    public GabrielScr gScript;

    public Enemy enemy1Scr;
    public Enemy enemy2Scr;
    public Enemy enemy3Scr;

    //CharacterButtons
    public Button floydButton;
    public Button maryButton;
    public Button gabrielButton;

    //EnemyButtons
    public Button Enemy1;
    public Button Enemy2;
    public Button Enemy3;

    //Active Character and Enemy
    public string activeChar;
    public string selectedEnemy;
      //get enemy script 

    //Round & Scene Manager
    public int currentRound = 1;
    public int currentWave = 1;
    public Scene scene;
    public string sceneName;

    //on click character


    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        moves.gameObject.SetActive(false);
        items.gameObject.SetActive(false);
        special.gameObject.SetActive(false);
        selection.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    //Moves goes down if character action is selected, if statement to see what active character it is so we can see if all characters have no moves then move on to next thing. idk.
    //check which character move it is so it does the appropriate amount of damage.
    //check if active character has moves left and then make the other buttons interactable.
    
    public void OnClickEnemy1()
    {
        selectedEnemy = "Enemy1";
    }

    public void OnClickEnemy2()
    {
        selectedEnemy = "Enemy2";
    }

    public void OnClickEnemy3()
    {
        selectedEnemy = "Enemy3";
    }



    public void OnClickFloyd()
    {
        maryButton.interactable = false;
        gabrielButton.interactable = false;
        floydButton.interactable = false;

        if (fScript.movesLeft == 1)
        {
            activeChar = fScript.charName;
            selection.gameObject.SetActive(true);

            move1Text.text = fScript.move1;
            move2Text.text = fScript.move2;
            move3Text.text = fScript.move3;

            specialText.text = fScript.specialMove;
            potionText.text = "Potions Left: " + fScript.potions;

            hpText.text = fScript.currentHealth + "/75";
            mpText.text = fScript.currentMana + "/50";
        }
        
    }

    public void OnClickMary()
    {
        maryButton.interactable = false;
        gabrielButton.interactable = false;
        floydButton.interactable = false;

        if (mScript.movesLeft == 1)
        {
            activeChar = mScript.charName;
            selection.gameObject.SetActive(true);

            move1Text.text = mScript.move1;
            move2Text.text = mScript.move2;
            move3Text.text = "";

            specialText.text = mScript.specialMove;
            potionText.text = "Potions Left: " + fScript.potions;

            hpText.text = mScript.currentHealth + "/130";
            mpText.text = mScript.currentMana + "/40";
        }

    }

    public void OnClickGabriel()
    {
        maryButton.interactable = false;
        gabrielButton.interactable = false;
        floydButton.interactable = false;

        if (gScript.movesLeft == 1)
        {
            activeChar = gScript.charName;
            selection.gameObject.SetActive(true);

            move1Text.text = gScript.move1;
            move2Text.text = gScript.move2;
            move3Text.text = "";

            specialText.text = gScript.specialMove;
            potionText.text = "Potions Left: " + gScript.potions;

            hpText.text = gScript.currentHealth + "/100";
            mpText.text = gScript.currentMana + "/50";
        }

    }

    public void OnClickMove()
    {
        selection.gameObject.SetActive(false);
        moves.gameObject.SetActive(true);
    }

    public void OnClickItem()
    {
        selection.gameObject.SetActive(false);
        items.gameObject.SetActive(true);
    }

    public void OnClickSpecial()
    {
        selection.gameObject.SetActive(false);
        special.gameObject.SetActive(true);
    }

    public void OnClickBack()
    {
        selection.gameObject.SetActive(true);
        moves.gameObject.SetActive(false);
        items.gameObject.SetActive(false);
        special.gameObject.SetActive(false);
    }

    public void OnClickMove1()
    {
        switch (activeChar)
        {
            case "Floyd":
                fScript.movesLeft--;
                maryButton.interactable = true;
                gabrielButton.interactable = true;
                
                if(selectedEnemy == "Enemy1")
                {
                    enemy1Scr.TakeDamage(5);
                }
                if (selectedEnemy == "Enemy2")
                {
                    enemy2Scr.TakeDamage(5);
                }
                if (selectedEnemy == "Enemy3")
                {
                    enemy3Scr.TakeDamage(5);
                }

                //take hp from enemy (-5)
                break;
            case "Gabriel":
                gScript.movesLeft--;
                maryButton.interactable = true;
                floydButton.interactable = true;

                if (selectedEnemy == "Enemy1")
                {
                    enemy1Scr.TakeDamage(15);
                }
                if (selectedEnemy == "Enemy2")
                {
                    enemy2Scr.TakeDamage(15);
                }
                if (selectedEnemy == "Enemy3")
                {
                    enemy3Scr.TakeDamage(15);
                }

                //take hp from enemy (-15)
                break;
            case "Mary":
                mScript.movesLeft--;
                floydButton.interactable = true;
                gabrielButton.interactable = true;

                if (selectedEnemy == "Enemy1")
                {
                    enemy1Scr.TakeDamage(25);
                }
                if (selectedEnemy == "Enemy2")
                {
                    enemy2Scr.TakeDamage(25);
                }
                if (selectedEnemy == "Enemy3")
                {
                    enemy3Scr.TakeDamage(25);
                }

                //take hp from enemy (-25)
                break;
        }
    }

    public void OnClickMove2()
    {
        switch (activeChar)
        {
            case "Floyd":
                fScript.movesLeft--;
                maryButton.interactable = true;
                gabrielButton.interactable = true;



                //heal selected team mate (+25HP -5MP)
                break;
            case "Gabriel":
                gScript.movesLeft--;
                maryButton.interactable = true;
                floydButton.interactable = true;

                gScript.GainMana(-10);

                if (selectedEnemy == "Enemy1")
                {
                    enemy1Scr.TakeDamage(20);
                }
                if (selectedEnemy == "Enemy2")
                {
                    enemy2Scr.TakeDamage(20);
                }
                if (selectedEnemy == "Enemy3")
                {
                    enemy3Scr.TakeDamage(20);
                }

                //take hp from enemy (-20HP -10MP)
                break;
            case "Mary":
                mScript.movesLeft--;
                //take hp from all enemies on board (-15)
                floydButton.interactable = true;
                gabrielButton.interactable = true;

                enemy1Scr.TakeDamage(15);
                enemy2Scr.TakeDamage(15);
                enemy3Scr.TakeDamage(15);

                break;
        }
    }

    public void OnClickMove3()
    {
        switch (activeChar)
        {
            case "Floyd":
                fScript.movesLeft--;
                maryButton.interactable = true;
                gabrielButton.interactable = true;

                if (selectedEnemy == "Enemy1")
                {
                    enemy1Scr.TakeDamage(15);
                }
                if (selectedEnemy == "Enemy2")
                {
                    enemy2Scr.TakeDamage(15);
                }
                if (selectedEnemy == "Enemy3")
                {
                    enemy3Scr.TakeDamage(15);
                }

                fScript.GainMana(-5);

                // -15HP , -5MP
                break;
            case "Gabriel":
                Debug.Log("No Move");
                break;
            case "Mary":
                Debug.Log("No Move");
                break;
        }
    }

    public void nextRound()
    {
        if (gScript.movesLeft == 0 && fScript.movesLeft == 0 && mScript.movesLeft == 0)
        {
            currentRound += 1;
            gScript.movesLeft += 1;
            fScript.movesLeft += 1;
            mScript.movesLeft += 1;
        }
    }

    public void nextWave()
    {
        if(enemy1Scr.currentHealth <= 0 && enemy2Scr.currentHealth <= 0 && enemy3Scr.currentHealth <= 0)
        {
            currentWave += 1;
        }
    }

}
