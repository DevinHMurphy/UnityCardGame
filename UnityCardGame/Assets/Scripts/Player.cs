using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    The player class contains all of the objects a player needs to
    participate in the "in-game" game flow.
*/

public class Player : MonoBehaviour
{
   //Reference Objects 
    //This field is to be set from ScriptableObject Dictionary and never interacted again.
    [SerializeField] public ScriptableObject deckSourceReference;
    //instantiated scriptableObject can be altered in gameplay
    private ScriptableObject deckSource;

    //This field is to be set from ScriptableObject Dictionary and never interacted again.
    [SerializeField] public ScriptableObject heroSoruceReference;
    //instantiated scriptableObject can be altered in gameplay
    private ScriptableObject heroSource;



    /* -- Hero Archetypes are out of scope 
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
    */
    //public GameClassType playerGameClass; -- out of scope
    public new string PlayerName;
    //public string uid;
    
    //THIS NEEDS TO BE REWORKED --> Player -> combatObject -> (defined by the Hero they have chosen)
    //Player's Health Stats
    public int maxHealth = 30;
    public int baseHealth = 30;
    public int health;

    //Player's Attack Stats
    public int attack;
    public int baseAttack = 0;

    // "In-game" Objects
    public GameObject gameDeckObj;
    public Deck deck;

    public GameObject combatObjectObj;
    public CombatObject combatObject;
    
    //Hand
    public GameObject handObj;
    public Hand hand;
    public int maxHandSize = 10;




    //Armor Currently Out of Scope
    //public int baseArmor = 0;
    //public int armor;


    public int fatigueCounter = 0;

    // -- out of scope (leaving for error problems)
    public int maxManaCrystals  = 10;
    public int baseManaCrystals = 1;
    public int mana;
    public int currentManaCrystals;

    /*
    public Weapon equippedWeapon;

    public HeroPower heroPower;
    */
    void Start()
    {   
        //Create the Deck Object
        gameDeckObj = new GameObject(name +"_GameDeck");
        //Make child of player
        gameDeck = gameDeckObj.AddComponent<Deck>();
        gameDeck.generateDeck(deck);

        handObj = new GameObject(name + "_Hand");
        hand = handObj.AddComponent<Hand>();

        //Create and populate character CombatObject
        combatObject = this.gameObject.AddComponent<CombatObject>();
        combatObject.SetStats(maxHealth, baseHealth, health, baseArmor, armor, attack, baseAttack);
        InitalizeStats();
        gameDeck.Shuffle();
    }
    //Create the Hand Object


    //TakeDamage: int -> (void)
    //Purpose to cause the players health to decrease when damaged
    //EFFECT: After called, the specified player's health will be set to their current health - input amount
    private void TakeDamage(int amount){
        combatObject.Damage(amount);
        this.health = combatObject.health;
        //create a player dmg flag
    }

    //ChangeCurrentHealth: int -> (void)
    //Purpose: to change the health of the specified person by the entered amount
    //EFFECT: the health of the specified player will be changed by the entered amount
    public void ChangeCurrentHealth(int delta) {
        this.health = this.health + delta;
    }
    
    //DrawMultipleCards: int -> (void)
    //Purpose: to draw multiple cards from the game deck and put them in the player's hand
    //EFFECT: after called, the players game deck will have the amount of cards input removed and their hand increased
        public void DrawMultipleCards(int drawAmount){
        for (int i = 0; i < drawAmount; i++){
            DrawCard();
        }
    }

    
/*
    public void AddToCardHand(Card card){
        hand.AddCard(card);
    }
*/

    //PlaySummonableCard: Card -> (void)
    //Purpose: to play the summonable card from the players hand to the board
    //EFFECT: the card will be removed from the players hand and put on the board
    //Assumption: Currently not accounting for Mana as it is outside of scope until next sprint
    public void PlaySummonableCard(Card targetCard){
            Debug.Log(PlayerName + " summoned a " + targetCard.name);
            Debug.Log(PlayerName + " now has " + mana + " mana");
            hand.Remove(targetCard);
        }
    }
 
    //PlaySpellCard: int -> (void)
    //Purpose: to play the spell card from the players hand to the "board"
    //EFFECT: the card will be removed from the players hand and "put on the board"
    //Assumption: Currently not accounting for Mana as it is outside of scope until next sprint
     public void PlaySpellCard(int targetCardIndex){
        //needs to be built out
    }

//Commenting out as Mana is not set until next sprint
/*
    public void SetManaCrystals(int number){
        currentManaCrystals = number;
    }
    public void IncreaseManaCrystals(int number){
        currentManaCrystals = currentManaCrystals + number;
    }

    public void SetCurrentMana(int amount){
        mana = amount;
    }

    public void AddMana(int amount){
        mana = mana + amount;
    }

    public void RefreshMana(){
        mana = currentManaCrystals;
    }
*/
    
    //Called every frame
    public void Update(){

    }
}
