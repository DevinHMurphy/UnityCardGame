using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MinionCardDisplay : MonoBehaviour
{
    public MinionCard card;

    private TextMeshProUGUI nameText;
    private TextMeshProUGUI descriptionText;
    private TextMeshProUGUI indexText;

    private Image artworkImage;

    private TextMeshProUGUI manaText;
    private TextMeshProUGUI attackText;
    private TextMeshProUGUI healthText;

    public MinionCardDisplay(MinionCard input){
        this.card = input;
    }
   
    public void SetCard(MinionCard input){
        this.card = input;
    }

    public MinionCard GetCard(){
        return this.card;
    }

    public void Render()
    {
        if(card != null){
            //this.gameObject.SetActive(true);
            this.nameText.text = this.card.name;

            //indexText.text = "# " + card.index; //OUT OF SCOPE

            //artworkImage.sprite = card.artwork; //this needs to be re-worked

            //manaText.text = card.manaCost.ToString(); //For mana implementation
            attackText.text = card.combatObject.getAttack().ToString();
            healthText.text = card.combatObject.getHealth().ToString();
        
        } else{
            //this.gameObject.SetActive(false);
        }
    }
    void Update(){
        Render();
    }
}
