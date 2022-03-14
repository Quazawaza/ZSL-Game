using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject {

    public new string name;
    public string description;
    public string skill;
    public string type;

    public Sprite artwork;
    public Sprite row;

    public int attack;

    public void Print ()
    {
        Debug.Log(name + ": " + description + " Karta ma " + attack + " ataku");
    }

}
