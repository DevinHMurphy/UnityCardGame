using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Minion", menuName = "ScriptableObject/Generic Minion")]
public class MinionScriptableObject : ScriptableObject
{

    [SerializeField] private string index;
    public string Index {get {return index;}}

    private GameObject cardObj;
    private MinionCard outputCard;

    /* -- OUT OF SCOPE
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
        */

    //DATA FIELDS
    [SerializeField] private new string name;
    public string Name {get {return name;}}

    //AUDIO FIELDS  -- OUT OF SCOPE
    /*
    [SerializeField] private AudioClip summonSound;
    public AudioClip Artwork {get {return summonSound;}} //This needs to be better built out
    //public AudioClip attackSound;
    //public AudioClip deathSound;
    */

    //VISUAL FIELDS
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

    public GameObject ConvertToCard(){
        return null;
    }

}
