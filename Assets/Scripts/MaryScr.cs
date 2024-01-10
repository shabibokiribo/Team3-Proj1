using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaryScr : MonoBehaviour
{
    //Character Stats
    public int hp = 130; //max 130
    public int mp = 0; //max 40, Increases +10 per turn

    public string charName = "Mary";

    //MOVESET
    public string move1 = "Pound"; // -25HP
    public string move2 = "Sweeping Blow"; // Hits all enemies -15HP
    public string specialMove = "Rage"; // -5HP additional to all attacks, Take less 5 damage from hits, -40MP, Lasts 2 turns

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
