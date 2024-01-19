using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    
    public Dialogue scrDialogue; //reference to dialogue script

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(scrDialogue);
    }
}
