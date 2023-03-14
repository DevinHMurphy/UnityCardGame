using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionCard : Card
{

    [SerializeField] public MinionScriptableObject minionSource;

    private MinionScriptableObject gameplayMinion;
    
    //public MinionType minionTypes; **TROUBLESHOOT LATER

    public int manaCost;

    public int defaultAttack;
    public int attack;
 
    public int defaultHealth;
    public int health;

    //Constructor
    public MinionCard(MinionScriptableObject minionSource){
        //Set card type to minion
        this.cardPlayType = CardPlayType.Minion;

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
    
    //Constructor
    public void UpdateMinionCard(string name,  string description, string index, Sprite artwork, int health, int attack, int manaCost){
        this.cardPlayType = CardPlayType.Minion;

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
        this.cardPlayType = CardPlayType.Minion;

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

    

    //METHODS

    public void Start(){
        //Set card type to minion
        cardPlayType = CardPlayType.Minion;

        //Load a version of the minion for reading
        gameplayMinion = ScriptableObject.Instantiate(minionSource);

        //load information from Scriptable Object
        health = defaultHealth = gameplayMinion.Health;
        attack = defaultAttack = gameplayMinion.Attack;
        manaCost = defaultManaCost = gameplayMinion.ManaCost;

        name = gameplayMinion.Name;
        description = gameplayMinion.Description;
        index = gameplayMinion.Index;

        artwork = gameplayMinion.Artwork;
        //cardRarity = gameplayMinion.thisRarity;
        //gameClassType = gameplayMinion.thisClassType; 
    }




    public void SetCurrentAttack(int value){
        attack = value;
    }

    public void ChangeCurrentAttack(int amount){
        if(attack + amount <= 0){
            //no negative attack
            attack = 0;
        } else {
            attack = attack + amount;
        }
    }


    public void SetDefaultHealth(int value){
        defaultHealth = value;
    }
    public void ChangeCurrentHealth(int amount){
        if(amount > 0){
            Heal(amount);
        }
        else if(amount < 0){
            Damage(amount);
        }
        else return;
    }

    public void Damage(int amount){
        health = health - amount;
    }
    public void Heal(int amount){
        if(defaultHealth - health < amount) {
            health = defaultHealth;
        }
        else {
            health = health + amount;
        }
    }
}
