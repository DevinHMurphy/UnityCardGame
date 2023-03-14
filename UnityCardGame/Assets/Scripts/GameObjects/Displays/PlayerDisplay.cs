using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PlayerDisplay : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private CombatObject combatObject;


    public TextMeshProUGUI nameText;

    public Image artworkImage;

    public TextMeshProUGUI armorText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;
    public void Render()
    {
        nameText.text = player.name;

        //artworkImage.sprite = card.artwork;

        armorText.text = combatObject.armor.ToString();
        attackText.text = combatObject.attack.ToString();
        healthText.text = combatObject.health.ToString();
    }


    // Update is called once per frame
    void Update()
    {
       // Render();
    }

    public void SetDisplayInformation(Player p, CombatObject co){
        this.player = p;
        this.combatObject = co;
    }
}
