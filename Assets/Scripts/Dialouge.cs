using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialouge : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TMP_Text dialogueText;
    public string[] dialogue;
    int index;

     
    float wordSpeed = 0.05f; //decrease the value to make the text speed go faster



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Typing());
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    void OnClickStartDialogue()
    {
        if(dialoguePanel.activeInHierarchy) //if dialogue box is not open, clear text
        {
            ClearText();
        }
        else
        {
            dialoguePanel.SetActive(true); //open dialogue box
            StartCoroutine(Typing()); //start typing, monkey
        }
    }

    void ClearText() //clear text and close text panel 
    {
        dialogueText.text = ""; //delete all words off dialogue box
        index = 0; // --\('-')/--
        dialoguePanel.SetActive(false); //close panel
    }

    public void NextLine() //Move to new line of dialogue
    {
        if (index < dialogue.Length -1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing()); //start typing, monkey
        }
        else
        {
            ClearText();
        }
    }

    IEnumerator Typing() //type out each letter in dialogue array (i think)
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    
}
