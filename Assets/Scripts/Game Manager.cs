using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GabrielScr Gabe; //reference
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClickCharacterSelection(string characterName) //when character is pressed sate the name of the character
    {
      Debug.Log("was selected"); //for testing purposes: state the name of character selection
    }
}
