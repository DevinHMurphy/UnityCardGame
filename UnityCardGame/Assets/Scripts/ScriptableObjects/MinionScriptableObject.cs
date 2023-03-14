using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Minion", menuName = "Board/Minion")]
public class MinionScriptableObject : CardReferenceScriptableObjects
{
    private GameObject cardObj;
    private MinionCard outputCard;

    public enum MinionType{
        Neutral,
        Beast,
        Demon,
        Dragon,
        Elemental,
        Homer,
        Mech,
        Murloc,
        Naga,
        Pirate,
        Totem,
        Undead
    }

    
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

    [SerializeField] private new string name;
    public string Name {get {return name;}}

    [SerializeField] public string description;
    public string Description {get {return description;}}

    //public AudioClip summonSound;
    //public AudioClip attackSound;
    //public AudioClip deathSound;

    /*
    [SerializeField] private GameClassType gameClassType; 
    public GameClassType thisClassType {get {return gameClassType;}}
    [SerializeField] private MinionType minionTypes; //LATER CHANGE TO LIST
    public MinionType thisMinionTypes {get {return minionTypes;}}
    [SerializeField] private CardRarity minionRarity;   
    public CardRarity thisRarity {get {return minionRarity;}}
    */

    [SerializeField] private Sprite artwork;
    public Sprite Artwork {get {return artwork;}}

    //public int defaultManaCost;
    [SerializeField] private int manaCost;
    public int ManaCost {get {return manaCost;}}


    //public Minion defaultCardSummon;
    [SerializeField] private int attack;
    public int Attack {get {return attack;}}
    [SerializeField] private int health;
    public int Health {get {return health;}}

    public override GameObject ConvertToCard(){
        //create a Card GameObject
        cardObj = new GameObject(this.Name +"_Card");
        outputCard = cardObj.AddComponent<MinionCard>();
        outputCard.UpdateMinionCard(this);
        //ouputCard.UpdateMinionCard(this.Name, this.Description, this.Index, this.Artwork, this.Health, this.Attack, this.ManaCost);  
        return cardObj;
    }

}
