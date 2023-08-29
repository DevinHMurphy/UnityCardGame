using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A card is any gameObject that makes up a deck 
public abstract class Card : MonoBehaviour {

    public new string name;
    public string description;

    public string index;

    public Sprite artwork;
    public CardRarity cardRarity;
    
    public int defaultManaCost;
    public int manaCost;

    public GameClassType gameClassType; 
    public CardType cardType;

    private GameObject displayObject;

    public GameObject getCardGameObject(){
        return this.gameObject;
    }

    public GameObject getDisplayObject(){
        return this.displayObject;
    }

    public abstract void generateDisplay();
}

public enum CardRarity{
    none,
    common,
    uncommon,
    rare,
    epic,
    legendary,
    mythic
}

public enum CardType{
    minion,
    spell,
    weapon //,
    //location
    }


