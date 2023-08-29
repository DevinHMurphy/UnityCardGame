using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionCard : Card
{
    //public scritable object used as reference but never altered
    [SerializeField] public MinionScriptableObject minionSource;

    //instantiated scriptableObject altered in gameplay
    private MinionScriptableObject gameplayMinion;
    
    public GameObject displayPrefab;

    //Card stats
    //defaults
    public int defaultAttack;
    public int defaultHealth;
    //Current stats 
    public int attack;
    public int health;


    
    //METHODS
    public MinionCard(MinionScriptableObject minionSource){
        //Set card type to minion
        this.cardType = CardType.minion;

        //Load a version of the minion for reading
        gameplayMinion = ScriptableObject.Instantiate(minionSource);

        //load information from Scriptable Object
        this.health = this.defaultHealth = gameplayMinion.Health;
        this.attack = this.defaultAttack = gameplayMinion.Attack;
        this.manaCost = this.defaultManaCost = gameplayMinion.ManaCost;

        this.name = gameplayMinion.Name;
        this.description = gameplayMinion.Description;
        this.index = gameplayMinion.Index;

        this.artwork = gameplayMinion.Artwork;
        //cardRarity = gameplayMinion.thisRarity;
        //gameClassType = gameplayMinion.thisClassType; 
    }
    
    //Update Card Info
    public void UpdateMinionCard(string name,  string description, string index, Sprite artwork, int health, int attack, int manaCost){
        this.cardType = CardType.minion;

        this.health = this.defaultHealth = health;
        this.attack = this.defaultAttack = attack;
        this.manaCost = this.defaultManaCost = manaCost;

        this.name = name;
        this.description = description;
        this.index = index;

        this.artwork = artwork;
    }

    public void UpdateMinionCard(MinionScriptableObject minionSource){
        this.minionSource = minionSource;
         //Set card type to minion
        this.cardType = CardType.minion;

        //Load a version of the minion for reading
        gameplayMinion = ScriptableObject.Instantiate(this.minionSource);

        //load information from Scriptable Object
        this.health = this.defaultHealth = gameplayMinion.Health;
        this.attack = this.defaultAttack = gameplayMinion.Attack;
        this.manaCost = this.defaultManaCost = gameplayMinion.ManaCost;

        this.name = gameplayMinion.Name;
        this.description = gameplayMinion.Description;
        this.index = gameplayMinion.Index;

        this.artwork = gameplayMinion.Artwork;
        //cardRarity = gameplayMinion.thisRarity;
        //gameClassType = gameplayMinion.thisClassType; 
    }  

    public override void generateDisplay()
    {
        
    }
}
