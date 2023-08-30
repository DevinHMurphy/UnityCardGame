using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : MonoBehaviour //THIS WHOLE CLASS IS OUTDATED AND SHOULD BE MOVED & DELTED
{

    [SerializeField] public MinionScriptableObject minionSource;

    private MinionScriptableObject gameplayMinion;
    
    public CombatObject combatObject;
    
    public Sprite artwork;

    public int defaultManaCost;
    public int manaCost;

    public int defaultAttack;
    public int attack;
 
    public int defaultHealth;
    public int health;

    //public int attack;
    //public int health;
    //public Effect cardEffect;
    //public CardType[] types;

    public void createMinion(){
        //create a copy of the source to be altered in play
        gameplayMinion = ScriptableObject.Instantiate(minionSource);
        health = defaultHealth = gameplayMinion.Health;
        attack = defaultAttack = gameplayMinion.Attack;
        manaCost = defaultManaCost = gameplayMinion.ManaCost;
        //Create and populate character CombatObject
        combatObject = this.gameObject.AddComponent<CombatObject>();
        combatObject.SetStats(defaultHealth, defaultHealth, health, 0, 0, attack, defaultAttack);

    }
  
}
