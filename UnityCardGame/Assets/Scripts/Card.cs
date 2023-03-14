using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Card : MonoBehaviour {
    public enum GameClassType{
        Neutral,
        Druid,
        Hunter,
        Mage,
        Paladin,
        Priest,
        Rogue,
        Shaman,
        Warlock,
        Warrior,
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

    public enum CardPlayType{
        Minion,
        Spell,
        BoardEffect
        //hero
        //weapon
    }

    public new string name;
    public string description;

    public string index; //decide if its string or int

    public Sprite artwork;
    public CardRarity cardRarity;
    
    public int defaultManaCost;
    public int currentManaCost;

    public GameClassType gameClassType; 
    public CardPlayType cardPlayType;

    //public abstract void onPlay();


    public void Print ()
	{
		Debug.Log(name + ": " + description + " The card costs: " + currentManaCost);
	}

}


