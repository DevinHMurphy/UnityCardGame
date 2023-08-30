using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    public void attack(combatObject source, combatObject recipient){
    }

    public void spellAttack(SpellCombatObject source, combatObject recipient){
        recipient.Damage(source.getAttack());
        //check if the recipient has been defeated
        recipient.isDead();
    }

}
