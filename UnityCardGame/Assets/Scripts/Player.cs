using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    The player class contains all of the objects a player needs to
    participate in the "in-game" game flow.
*/

public class Player : MonoBehaviour
{
    /* -- classes are out of scope 
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

    public new string name;
    //public string uid;

    //public GameClassType playerGameClass; -- out of scope


    //THIS NEEDS TO BE REWORKED --> Player -> combatObject -> (defined by the Hero they have chosen)
    public int maxHealth = 30;
    public int baseHealth = 30;
    public int health;

    public int baseArmor = 0;
    //public int armor;

    public int attack;
    public int baseAttack = 0;

    //public int fatigueCounter = 0;

    // -- out of scope (leaving for error problems)
    public int maxManaCrystals  = 10;
    public int baseManaCrystals = 1;
    public int mana;
    public int currentManaCrystals;

    /*
    public Weapon equippedWeapon;

    public HeroPower heroPower;
    */

    //Reference Objects 
    //This field is to be set from ScriptableObject Dictionary and never interacted again.
    [SerializeField] public ScriptableObject deckSourceReference;
    //instantiated scriptableObject can be altered in gameplay
    private ScriptableObject deckSource;

    //This field is to be set from ScriptableObject Dictionary and never interacted again.
    [SerializeField] public ScriptableObject heroSoruceReference;
    //instantiated scriptableObject can be altered in gameplay
    private ScriptableObject heroSource;

    // "In-game" Objects
    public GameObject gameDeckObj;
    public Deck deck;

    public GameObject combatObjectObj;
    public CombatObject combatObject;

    public int maxHandSize = 10;

    //Hand
    public GameObject handObj;
    public Hand hand;
 

    public Player(){
        
    }
    /*
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
    */
    public void InitializePlayer(){
        //Create the Deck Object
        gameDeckObj = new GameObject(name +"_GameDeck");
        //Make child of player (The Deck)
        gameDeck = gameDeckObj.AddComponent<Deck>();
        gameDeck.generateDeck(deck);
        //gameDeck.Shuffle();
        //Make Hand
        handObj = new GameObject(name + "_Hand");
        hand = handObj.AddComponent<Hand>();

        //Create and populate character CombatObject
        combatObjectObj = new GameObject(name +"_CombatObject");
        combatObjectObj.transform.parent = this.gameObject.transform;
        combatObject = combatObjectObj.AddComponent<CombatObject>();
        combatObject.SetStats(maxHealth, baseHealth, health, baseArmor, armor, attack, baseAttack);
        InitalizeStats();


    }

    //public Minion Board;
    //public List<Card> board = new List<Card>();
    
    public void DrawCard(int drawAmount){
        for (int i = 0; i < drawAmount; i++){
            DrawCard();
        }
    }

    public void AddToCardHand(Card card){
        hand.AddCard(card);
    }

    public void DrawCard(){
        if (gameDeck != null){
            if(gameDeck.GetSize() > 0){
                Card tempCard = gameDeck.DrawCard();
                hand.AddCard(tempCard);
                Debug.Log(name + " drew a " + tempCard.name);
            }
            else {
                fatigueCounter++;
                Debug.Log(name + " gameDeck's empty and but tried to draw a card, they take " + fatigueCounter + " Damage");
                TakeDamage(fatigueCounter);

            }
        } else{
            Debug.Log(name + " gameDeck is null");

        }

    }

    public void PlayCard(int targetCardIndex){
        //needs to be built out
    }

    //change to play card
    public void PlayCard(Card targetCard){
        if(mana > targetCard.manaCost){
            //board.Add(targetCard);
            mana = mana - targetCard.manaCost;
            Debug.Log(name + " summoned a " + targetCard.name);
            Debug.Log(name + " now has " + mana + " mana");
            hand.Remove(targetCard);
        }
    }

    public void SetManaCrystals(int number){
        currentManaCrystals = number;
    }
    public void IncreaseManaCrystals(int number){
        currentManaCrystals = currentManaCrystals + number;
    }

    private void TakeDamage(int amount){
        combatObject.Damage(amount);
        this.health = combatObject.health;

        //create a player dmg flag
    }

    public void ChangeCurrentHealth(int delta) {
        health = health + delta;
    }

    public void SetCurrentHealth(int amount){
        health = amount;
    }

    public void SetCurrentMana(int amount){
        mana = amount;
    }

    public void AddMana(int amount){
        mana = mana + amount;
    }

    public void InitalizeStats(){
        health = baseHealth;
        attack = baseAttack;
        armor = baseArmor;
        fatigueCounter = 0;
        SetManaCrystals(1);
        RefreshMana();

    }

    public void RefreshMana(){
        mana = currentManaCrystals;
    }


    //Called every frame
    public void Update(){

    }
}
