using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

    //CharacterButtons
    public Button floydButton;
    public Button maryButton;
    public Button gabrielButton;

    //Active Character and Enemy
    public string activeChar;
    public GameObject selectedEnemy;
      //get enemy script 

    //Round Manager
    public int currentRound = 1;

    //on click character


    // Start is called before the first frame update
    void Start()
    {
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

            hpText.text = fScript.hp + "/75";
            mpText.text = fScript.mp + "/50";
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

            hpText.text = mScript.hp + "/130";
            mpText.text = mScript.mp + "/40";
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

            hpText.text = gScript.hp + "/100";
            mpText.text = gScript.mp + "/50";
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
                //take hp from selected enemy (-5)
                break;
            case "Gabriel":
                gScript.movesLeft--;
                maryButton.interactable = true;
                floydButton.interactable = true;
                //take hp from enemy (-15)
                break;
            case "Mary":
                mScript.movesLeft--;
                //take hp from enemy (-25)
                floydButton.interactable = true;
                gabrielButton.interactable = true;
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
                //take hp from enemy (-20HP -10HP)
                break;
            case "Mary":
                mScript.movesLeft--;
                //take hp from all enemies on board (-15)
                floydButton.interactable = true;
                gabrielButton.interactable = true;
                break;
        }
    }

}
