using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardCreator : MonoBehaviour {

    public Card card;

    public Text nameText;
    public Text descriptionText;
    public Text skillText;
    public Text typeText;

    public Image artworkImage;
    public Image rowImage;

    public Text attackText;

    // Start is called before the first frame update
    void Start() {
        nameText.text = card.name;
        descriptionText.text = card.description;

        artworkImage.sprite = card.artwork;
        rowImage.sprite = card.row;

        attackText.text = card.attack.ToString();

        card.Print();
    }


}
