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
    public int currentRound = 0;
    public int currentWave = 0;
    public Scene scene;
    public string sceneName;

    public TMP_Text roundText;

    //Sprites
    public Sprite gStanding;
    public Sprite gMove1;
    public Sprite gMove2;
    public Sprite gSpecial;

    public int randomMove;

    public bool multi = false;




    //MAKE ENEMY.ISCHECKED FALSE WHENEVER SCENE SWITCHES
    //MAKE THE MANA CHANGE BASED ON ROUND


    // Start is called before the first frame update
    void Start()
    {

        currentRound = 1;
        nextWave();
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        moves.gameObject.SetActive(false);
        items.gameObject.SetActive(false);
        special.gameObject.SetActive(false);
        selection.gameObject.SetActive(false);

        moveErrorText.text = " ";
        specialErrorText.text = " ";
        potionErrorText.text = " ";

    }

    // Update is called once per frame
    void Update()
    {
        roundText.text = "Round " + currentRound;

        if (mScript.movesLeft == 0)
        {
            maryButton.interactable = false;
        }
        if (fScript.movesLeft == 0)
        {
            floydButton.interactable = false;
        }
        if (gScript.movesLeft == 0)
        {
            gabrielButton.interactable = false;
 
        }

        if (enemy1Scr.currentHealth <= 0 && enemy2Scr.currentHealth <= 0 && enemy3Scr.currentHealth <= 0)
        {
            nextWave();
        }
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

        switch (activeChar)
        {
            case "Floyd":

                if(fScript.currentMana < 40)
                {
                    specialErrorText.text = "Not Enough Mana";
                }

                else
                {
                    fScript.movesLeft--;

                    fScript.TakeDamage(-25);
                    gScript.TakeDamage(-25);
                    mScript.TakeDamage(-25);

                    fScript.GainMana(-40);

                    //give  hp to party (25) & take 40 mana from floyd
                }


                break;
            case "Gabriel":

                if (gScript.currentMana < 40)
                {
                    specialErrorText.text = "Not Enough Mana";
                }

                else
                {
                    gScript.movesLeft--;

                    gabrielButton.GetComponent<SpriteRenderer>().sprite = gSpecial;

                    if (selectedEnemy == "Enemy1")
                    {
                        enemy1Scr.TakeDamage(35);
                    }
                    if (selectedEnemy == "Enemy2")
                    {
                        enemy2Scr.TakeDamage(35);
                    }
                    if (selectedEnemy == "Enemy3")
                    {
                        enemy3Scr.TakeDamage(35);
                    }

                    gScript.GainMana(-40);
                }

                

                //take hp from enemy (-35) &  take 40 mana
                break;
            case "Mary":
                if (mScript.currentMana < 40)
                {
                    specialErrorText.text = "Not enough mana";
                }

                mScript.movesLeft--;



                // -5HP additional to all attacks, Take less 5 damage from hits, -40MP, Lasts 2 turns

                break;


        }
        TurnReset();
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
        Debug.Log("move1");
        switch (activeChar)
        {
            case "Floyd":
                fScript.movesLeft--;
                
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

                gabrielButton.GetComponent<Image>().sprite = gMove1;

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
            default: Debug.Log(activeChar); break;

            
        }
        TurnReset();
    }

    public void OnClickMove2()
    {
        switch (activeChar)
        {
            case "Floyd":

                if(fScript.currentMana < 5)
                {
                    moveErrorText.text = "Not enough mana";
                }

                else
                {
                    fScript.movesLeft--;
                }
                



                //heal selected team mate (+25HP -5MP)
                break;
            case "Gabriel":

                if(gScript.currentMana < 10)
                {
                    moveErrorText.text = "Not enough mana";
                }

                else
                {
                    gScript.movesLeft--;

                    gabrielButton.GetComponent<Image>().sprite = gMove2;

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
                }

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
        TurnReset();
    }

    public void OnClickMove3()
    {
        switch (activeChar)
        {
            case "Floyd":

                if (fScript.currentMana > 5)
                {
                    moveErrorText.text = "Not enough mana";
                }

                else
                {
                    fScript.movesLeft--;

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
                }
                

                // -15HP , -5MP
                break;
            case "Gabriel":
                Debug.Log("No Move");
                break;
            case "Mary":
                Debug.Log("No Move");
                break;
        }
        TurnReset();
    }

    public void TurnReset()
    {
        selection.gameObject.SetActive(false);
        moves.gameObject.SetActive(false);
        special.gameObject.SetActive(false);
        items.gameObject.SetActive(false);

        selectedEnemy = null;

        nextRound();

        nextWave();

        gabrielButton.GetComponent<Image>().sprite = gStanding;

        specialErrorText.text = " ";
        moveErrorText.text = " ";
        potionErrorText.text = " ";

    }

    public void nextRound()
    {
        if (gScript.movesLeft == 0 && fScript.movesLeft == 0 && mScript.movesLeft == 0)
        {
            gabrielButton.interactable = true;
            maryButton.interactable = true;
            floydButton.interactable = true;

            EnemyAttack();
            currentRound += 1;
            gScript.movesLeft += 1;
            fScript.movesLeft += 1;
            mScript.movesLeft += 1;
            nextWave();

            gScript.GainMana(10);
            mScript.GainMana(10);
            fScript.GainMana(10);

            enemy1Scr.GainMana(10);
            enemy2Scr.GainMana(10);
            enemy3Scr.GainMana(10);
        }
    }

    public void EnemyAttack()
    {
        if (enemy1Scr.currentMana != enemy1Scr.mp)
        {
            randomMove = Random.Range(0, 2);
        }
        else if (enemy2Scr.currentMana != enemy2Scr.mp)
        {
            randomMove = Random.Range(0, 2);
        }
        else if (enemy3Scr.currentMana != enemy3Scr.mp)
        {
            randomMove = Random.Range(0, 2);
        }
        else
        {
            if (enemy1Scr.enemyName == "Angel")
            {
                multi = true;
                enemy1Scr.EnemySpecial(5);
                multi = false;
            }
            if (enemy2Scr.enemyName == "Angel")
            {
                multi = true;
                enemy2Scr.EnemySpecial(5);
                multi = false;
            }
            if (enemy3Scr.enemyName == "Angel")
            {
                multi = true;
                enemy3Scr.EnemySpecial(5);
                multi = false;
            }

            //==================================

            if (enemy1Scr.enemyName == "Cherub")
            {
                multi = true;
                enemy1Scr.EnemySpecial(10);
                multi = false;
            }
            if (enemy2Scr.enemyName == "Cherub")
            {
                multi = true;
                enemy2Scr.EnemySpecial(10);
                multi = false;
            }
            if (enemy3Scr.enemyName == "Cherub")
            {
                multi = true;
                enemy3Scr.EnemySpecial(10);
                multi = false;
            }

            //==================================

            if (enemy1Scr.enemyName == "Hula Dancer")
            {
                multi = true;
                enemy1Scr.EnemySpecial(15);
                multi = false;
            }
            if (enemy2Scr.enemyName == "Hula Dancer")
            {
                multi = true;
                enemy2Scr.EnemySpecial(15);
                multi = false;
            }
            if (enemy3Scr.enemyName == "Hula Dancer")
            {
                multi = true;
                enemy3Scr.EnemySpecial(15);
                multi = false;
            }

            //==================================

            if (enemy1Scr.enemyName == "Coconut Tree")
            {
                enemy1Scr.EnemySpecial(30);
            }
            if (enemy2Scr.enemyName == "Coconut Tree")
            {
                enemy2Scr.EnemySpecial(30);
            }
            if (enemy3Scr.enemyName == "Coconut Tree")
            {
                enemy3Scr.EnemySpecial(30);
            }

            //==================================

            if (enemy1Scr.enemyName == "Demon")
            {
                multi = true;
                enemy1Scr.EnemySpecial(20);
                multi = false;
            }
            if (enemy2Scr.enemyName == "Demon")
            {
                multi = true;
                enemy2Scr.EnemySpecial(20);
                multi = false;
            }
            if (enemy3Scr.enemyName == "Demon")
            {
                multi = true;
                enemy3Scr.EnemySpecial(20);
                multi = false;
            }

            //==================================

            if (enemy1Scr.enemyName == "Volcano")
            {
                multi = true;
                enemy1Scr.EnemySpecial(10);
                multi = false;
            }
            if (enemy2Scr.enemyName == "Volcano")
            {
                multi = true;
                enemy2Scr.EnemySpecial(10);
                multi = false;
            }
            if (enemy3Scr.enemyName == "Volcano")
            {
                multi = true;
                enemy3Scr.EnemySpecial(10);
                multi = false;
            }

            //==================================

            if (enemy1Scr.enemyName == "Cerberus")
            {
                multi = true;
                enemy1Scr.EnemySpecial(35);
                multi = false;
            }

            //==================================
     
    }


        if (randomMove == 0)
        {
            if (enemy1Scr.enemyName == "Angel")
            {
                enemy1Scr.EnemyMove1(10);
            }
            if (enemy2Scr.enemyName == "Angel")
            {
                enemy2Scr.EnemyMove1(10);
            }
            if (enemy3Scr.enemyName == "Angel")
            {
                enemy3Scr.EnemyMove1(10);
            }

            //==================================

            if (enemy1Scr.enemyName == "Cherub")
            {
                enemy1Scr.EnemyMove1(5);
            }
            if (enemy2Scr.enemyName == "Cherub")
            {
                enemy2Scr.EnemyMove1(5);
            }
            if (enemy3Scr.enemyName == "Cherub")
            {
                enemy3Scr.EnemyMove1(5);
            }

            //==================================

            if (enemy1Scr.enemyName == "Hula Dancer")
            {
                enemy1Scr.EnemyMove1(10);
            }
            if (enemy2Scr.enemyName == "Hula Dancer")
            {
                enemy2Scr.EnemyMove1(10);
            }
            if (enemy3Scr.enemyName == "Hula Dancer")
            {
                enemy3Scr.EnemyMove1(10);
            }

            //==================================

            if (enemy1Scr.enemyName == "Coconut Tree")
            {
                enemy1Scr.EnemyMove1(15);
            }
            if (enemy2Scr.enemyName == "Coconut Tree")
            {
                enemy2Scr.EnemyMove1(15);
            }
            if (enemy3Scr.enemyName == "Coconut Tree")
            {
                enemy3Scr.EnemyMove1(15);
            }

            //==================================

            if (enemy1Scr.enemyName == "Demon")
            {
                enemy1Scr.EnemyMove1(10);
            }
            if (enemy2Scr.enemyName == "Demon")
            {
                enemy2Scr.EnemyMove1(10);
            }
            if (enemy3Scr.enemyName == "Demon")
            {
                enemy3Scr.EnemyMove1(10);
            }

            //==================================

            if (enemy1Scr.enemyName == "Volcano")
            {
                enemy1Scr.EnemyMove1(15);
            }
            if (enemy2Scr.enemyName == "Volcano")
            {
                enemy2Scr.EnemyMove1(15);
            }
            if (enemy3Scr.enemyName == "Volcano")
            {
                enemy3Scr.EnemyMove1(15);
            }

            //==================================

            if (enemy1Scr.enemyName == "Cerberus")
            {
                enemy1Scr.EnemyMove1(25);
            }

            //==================================



        }

        if (randomMove == 1)
        {
            if (enemy1Scr.enemyName == "Angel")
            {
                enemy1Scr.EnemyMove2(20);
            }
            if (enemy2Scr.enemyName == "Angel")
            {
                enemy2Scr.EnemyMove2(20);
            }
            if (enemy3Scr.enemyName == "Angel")
            {
                enemy3Scr.EnemyMove2(20);
            }

            //==================================

            if (enemy1Scr.enemyName == "Cherub")
            {
                enemy1Scr.EnemyMove2(10);
            }
            if (enemy2Scr.enemyName == "Cherub")
            {
                enemy2Scr.EnemyMove2(10);
            }
            if (enemy3Scr.enemyName == "Cherub")
            {
                enemy3Scr.EnemyMove2(10);
            }

            //==================================

            if (enemy1Scr.enemyName == "Hula Dancer")
            {
                enemy1Scr.EnemyMove2(15);
            }
            if (enemy2Scr.enemyName == "Hula Dancer")
            {
                enemy2Scr.EnemyMove2(15);
            }
            if (enemy3Scr.enemyName == "Hula Dancer")
            {
                enemy3Scr.EnemyMove2(15);
            }

            //==================================

            if (enemy1Scr.enemyName == "Coconut Tree")
            {
                enemy1Scr.EnemyMove2(20);
            }
            if (enemy2Scr.enemyName == "Coconut Tree")
            {
                enemy2Scr.EnemyMove2(20);
            }
            if (enemy3Scr.enemyName == "Coconut Tree")
            {
                enemy3Scr.EnemyMove2(20);
            }

            //==================================

            if (enemy1Scr.enemyName == "Demon")
            {
                enemy1Scr.EnemyMove2(30);
            }
            if (enemy2Scr.enemyName == "Demon")
            {
                enemy2Scr.EnemyMove2(30);
            }
            if (enemy3Scr.enemyName == "Demon")
            {
                enemy3Scr.EnemyMove2(30);
            }

            //==================================

            if (enemy1Scr.enemyName == "Volcano")
            {
                enemy1Scr.EnemyMove2(0);
            }
            if (enemy2Scr.enemyName == "Volcano")
            {
                enemy2Scr.EnemyMove2(0);
            }
            if (enemy3Scr.enemyName == "Volcano")
            {
                enemy3Scr.EnemyMove2(0);
            }

            //==================================

            if (enemy1Scr.enemyName == "Cerberus")
            {
                enemy1Scr.EnemyMove2(25);
            }

            //==================================



        }

    }


    public void nextWave()
    {
            currentWave += 1;
            Invoke("checkEnemy", 1.0f);
    }

    public void checkEnemy()
    {
        enemy1Scr.isChecked = true;
        enemy2Scr.isChecked = true; 
        enemy3Scr.isChecked = true;
        Invoke("resetCheckEnemy", 1.0f);
    }

    public void resetCheckEnemy()
    {
        enemy1Scr.isChecked = false;
        enemy2Scr.isChecked = false;
        enemy3Scr.isChecked = false;
    }

    public void OnClickPotion()
    {
        if(fScript.potions > 1 && activeChar == "Floyd")
        {
            potionErrorText.text = "No potions";
        }
        if (gScript.potions > 1 && activeChar == "Gabriel")
        {
            potionErrorText.text = "No potions";
        }
        if (gScript.potions > 1 && activeChar == "Gabriel")
        {
            potionErrorText.text = "No potions";
        }
        if (activeChar == "Mary")
        {
            potionErrorText.text = "No potions";
        }

        else
        {
            if(activeChar == "Floyd")
            {
                fScript.TakeDamage(-10);
                fScript.GainMana(5);
            }
            if (activeChar == "Gabriel")
            {
                gScript.TakeDamage(-10);
                gScript.GainMana(5);
            }
            if (activeChar == "Mary")
            {
                mScript.TakeDamage(-10);
                mScript.GainMana(5);
            }
        }
    }

}
