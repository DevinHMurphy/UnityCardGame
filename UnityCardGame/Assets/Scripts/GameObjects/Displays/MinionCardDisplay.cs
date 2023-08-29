using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MinionCardDisplay : MonoBehaviour
{
    public MinionCard card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI indexText;

    public Image artworkImage;

    public TextMeshProUGUI manaText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;

    public void SetCard(MinionCard input){
        this.card = input;
    }

      public void SetCard(Card input){
        if (input is MinionCard){
            this.card = input;
        } else{
             Debug.Log("Error : Incorrect Card Type on " + this.gameObject.name );
        }
    }

    public Card GetCard(){
        return card;
    }

    public void Render()
    {
        if(card != null){
            //this.gameObject.SetActive(true);
            nameText.text = card.name;
            descriptionText.text = card.description;

            indexText.text = "# " + card.index;

            artworkImage.sprite = card.artwork;

            manaText.text = card.manaCost.ToString();
            attackText.text = card.attack.ToString();
            healthText.text = card.health.ToString();
        
        } else{
            //this.gameObject.SetActive(false);
        }
    }
    void Update(){
        Render();
    }
}
