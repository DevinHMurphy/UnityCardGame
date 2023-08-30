using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
The card class references a scriptable object and initalizes it for play in the game cycle
*/
public abstract class Card : MonoBehaviour {
    
    public enum CardPlayType{
    Minion,
    Spell
    }

    //This field is to be set from ScriptableObject Dictionary and never interacted again.
    [SerializeField] public ScriptableObject cardSourceReference;
    //instantiated scriptableObject can be altered in gameplay
    private ScriptableObject cardSource;

    //Constants
    public new string name;
    private 
    /* -- Out of scope
    public int defaultManaCost;
    public int manaCost;
    */ 

    //visual Constants -- these will be populated from the scriptable object
    //public GameClassType gameClassType; -- no hero classes yet out of scope
    public CardPlayType cardPlayType;

    //Card display prefab
    private GameObject displayObject;
    private GameObejct combatObject; 



    //getters
    public GameObject getCardGameObject(){
        return this.gameObject;
    }
    public GameObject getDisplayObject(){
        return this.displayObject;
    }

    //Delegate the creation of the display object
    public abstract void generateDisplay();

    //Delegate the actions on card creation
    public abstract void Start();
}

/* -- Out of scope
public enum CardRarity{
    None,
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Mythic
}
*/

    


