using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Dialogue : MonoBehaviour
{
    public TMP_Text charName;

    [TextArea(3,10)] //min and max amount of sentences
    public string[] sentences; //sentences that will be loaded into que

    //charName.text = ("Generic Name"); //INSERT CHARACTER NAME HERE
}
