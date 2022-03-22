using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject {

    public string title;
    public string description;
    // public string type;
    // public string skill;

    public Sprite artwork;
    public Sprite row;

    public int attack;

    public void Print () {
        Debug.Log(title + ": " + description + " Karta ma " + attack + " ataku");
    }

}
