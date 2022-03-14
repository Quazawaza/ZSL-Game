using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject {

    public new string name;
    public string description;
    public string type;
    public string skill;

    public Image artwork;
    public Image row;

    public int attack;

    public void Print ()
    {
        Debug.Log(name + ": " + description + " Karta ma " + attack + " ataku");
    }

}
