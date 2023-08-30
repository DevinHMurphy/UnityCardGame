using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Extends card to create "in-game" Card that contains a minion.
*/
public class MinionCard : Card
{
    private MinionDisplay minionDisplayObject; //Needs to be instantiated and on start()

    //public scritable object used as reference but never altered
    [SerializeField] public MinionScriptableObject minionSource;
    //instantiated scriptableObject altered in gameplay
    private MinionScriptableObject gameplayMinion;
    
    //Constructor
    public MinionCard(MinionScriptableObject minionSource){
        //Set card type to minion -- OUT OF SCOPE
        //this.cardType = CardType.minion;

        //Load a version of the minion for reading -- This is another level of security to ensure the original minion source is Never altered
        gameplayMinion = ScriptableObject.Instantiate(minionSource);

        //load information from Scriptable Object
        this.health = this.defaultHealth = gameplayMinion.Health;
        this.attack = this.defaultAttack = gameplayMinion.Attack;
        //this.manaCost = this.defaultManaCost = gameplayMinion.ManaCost; -- OUT OF SCOPE

        this.name = gameplayMinion.Name;
        this.description = gameplayMinion.Description;
        //this.index = gameplayMinion.Index; -- This is redundant and does not matter to the gameplay, unless future features require it

        //this.artwork = gameplayMinion.Artwork; -- Should be stored on the Display object
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

    //Update all the in-game object of the MinionCard
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

    public 

    public override void generateDisplay()
    {
        
    }
}
