using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MinionCardDisplay : MonoBehaviour
{
    private MinionScriptableObject cardSource;
    private MinionCard card;
    public CombatObject combatObject;

    private TextMeshProUGUI nameText;
    private TextMeshProUGUI descriptionText;
    private TextMeshProUGUI indexText;

    private Image artworkImage;

    private TextMeshProUGUI manaText;
    private TextMeshProUGUI attackText;
    private TextMeshProUGUI healthText;

    public MinionCardDisplay(MinionCard card){
        this.card = card;
        this.cardSource = this.card.getGameplayMinion();
        this.combatObject = this.card.combatObject;
    }

    public void Render()
    {   
        if(card != null){
            if(card.getPlayState() == MinionCard.PlayState.InHand){
                //this.gameObject.SetActive(true);
                this.nameText.text = this.cardSource.Name;

                //indexText.text = "# " + card.index; //OUT OF SCOPE

                //artworkImage.sprite = card.artwork; //this needs to be re-worked

                //manaText.text = card.manaCost.ToString(); //For mana implementation
            attackText.text = this.combatObject.getAttack().ToString();
            healthText.text = this.combatObject.getHealth().ToString();
            } else if (card.getPlayState() == MinionCard.PlayState.InPlay){
            //In Play Render
            } else {
            //Card in Deck
            }
        }
    }
    void Update(){
        Render();
    }
}
