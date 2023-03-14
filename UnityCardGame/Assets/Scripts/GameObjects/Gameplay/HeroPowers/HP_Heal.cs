using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Heal : HeroPower {

    public HP_Heal(){
        name = "Lesser Heal";
        description = "Restore 2 health.";
        cost = 2;
        power = 2;
    }

    public override void Activate(Player target){
        target.ChangeCurrentHealth(power);
    }
    /*
    public void Activate(Minion target){
        target.ChangeCurrentHealth(power);
    }
    */
}