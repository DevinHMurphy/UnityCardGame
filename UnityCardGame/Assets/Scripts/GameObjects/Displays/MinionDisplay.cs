using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MinionDisplay : MonoBehaviour
{
    public Minion minion;

    public Image artworkImage;

    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;

    //Create a list of the effects that are on this minion
    //public boolean hasTaunt;
    
    public void Render()
    {
        if(minion != null){
            this.gameObject.SetActive(true);
            artworkImage.sprite = minion.artwork;
            attackText.text = minion.attack.ToString();
            healthText.text = minion.health.ToString();
        } else {
            this.gameObject.SetActive(false);
        }
    }

    void update(){
        Render();
    }
}
