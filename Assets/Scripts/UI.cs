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

    //Active Character
    public string activeChar;

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

    public void OnClickMove()
    {
        selection.gameObject.SetActive(false);
        moves.gameObject.SetActive(true);
    }

    //Moves goes down if character action is selected, if statement to see what active character it is so we can see if all characters have no moves then move on to next thing. idk.
    //check which character move it is so it does the appropriate amount of damage.

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
}
