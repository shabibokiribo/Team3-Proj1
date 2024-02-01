using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator myAnimator;
    const string redAnimation = "Red"; //red animation trigger
    const string equipGunAnimation = "equipGun"; //arm animation trigger
    const string angelAttackAnimation = "AngelAttack"; //Angel Attack animation trigger
    const string barbAttackAnimation = "Guitar"; //Barb Attack animation trigger
    const string barbColorChangeAnimation = "Color"; //Barb Attack animation trigger
   // public UI UiButtons; //reference to script

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(UiButtons.selectedEnemy == "Enemy1") //if enemy 1 is click...
        if(Input.GetKeyDown(KeyCode.Space)) //if spacebar is clicked...
        {
            Debug.Log("starting red animation for enemy 1");
            myAnimator.SetTrigger(redAnimation); //start red animation
            myAnimator.SetTrigger(equipGunAnimation); //start equpGun animation
            myAnimator.SetTrigger(angelAttackAnimation); //start AngelAttack animation
            myAnimator.SetTrigger(barbAttackAnimation); //start BarbAttack animation
             myAnimator.SetTrigger(barbColorChangeAnimation); //start barb body color animation
        }
        //if(UiButtons.selectedEnemy == "Enemy2") //if enemy 1 is click...
        if(Input.GetKeyDown(KeyCode.W)) //is 'W' is clicked
        {
            Debug.Log("starting red animation for enemy 2");
            myAnimator.SetTrigger(redAnimation); //start red animation
            myAnimator.SetTrigger(equipGunAnimation); //start equpGun animation
        }
        //if(UiButtons.selectedEnemy == "Enemy3") //if enemy 1 is click...
        if(Input.GetKeyDown(KeyCode.A)) //is 'A' is clicked
        {
            Debug.Log("starting red animation for enemy 3");
            myAnimator.SetTrigger(redAnimation); //start red animation
            myAnimator.SetTrigger(equipGunAnimation); //start equpGun animation
        }
    }

   /* void OnMouseDown() //after the player selects an move to use on an enemy, begin animation
    {
        myAnimator.SetTrigger(redAnimation);
    }
    */


    
}
