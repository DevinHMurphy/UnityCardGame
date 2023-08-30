using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public void attack(CombatObject source, CombatObject recipient){
    }

    public void spellAttack(SpellCombatObject source, CombatObject recipient){
        recipient.Damage(source.getAttack());
        //check if the recipient has been defeated
        recipient.isDead();
        //if it is dead move it to the correct graveyard

        //temp destroy object
        //recipient.Destroy();
    }

}
