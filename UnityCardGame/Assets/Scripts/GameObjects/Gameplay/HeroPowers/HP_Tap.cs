using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Tap : HeroPower {

    public HP_Tap(){
        name = "Life Tap";
        description = "Draw a card and take two damage.";
        cost = 2;
        power = 1;
    }


    public override void Activate(Player target){
        target.ChangeCurrentHealth(cost);
        target.DrawCard();
    }
}