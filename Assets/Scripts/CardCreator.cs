using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardCreator : MonoBehaviour {

    public Card card;

    public Text title;
    public Text description;
    // public Text skill;
    // public Text type;

    public Image artwork;
    public Image row;

    public Text attack;

    // Start is called before the first frame update
    private void Start() {
        LoadCard(card);
    }
    
    public void LoadCard(Card card) {
        if(card == null) {
            return;
        }
        this.card = card;

        title.text = card.title;
        description.text = card.description;
        // skill.text = card.skill;
        // type.text = card.type;

        artwork.sprite = card.artwork;
        row.sprite = card.row;

        attack.text = card.attack.ToString();
        card.Print();
    }
}
