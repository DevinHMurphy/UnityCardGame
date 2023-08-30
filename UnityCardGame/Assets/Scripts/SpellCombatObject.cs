using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    The combat object contains the values of each "in-game" 
    spell object, that allow it to effect creatures that undergo combat.
    The combat manager uses multiple combatObjects to create a combat flow.
*/
public class SpellCombatObject : MonoBehaviour
{
    private int baseAttack = 0;
    private int attack = 0;

    //Constructor
    public CombatObject(int baseAttack, int attack){
        this.attack = Attack;
        this.baseAttack = BaseAttack; 
    }

    public int getBaseAttack(){
        return this.baseAttack;
    }

    public int getAttack(){
        return this.attack;
    }
}