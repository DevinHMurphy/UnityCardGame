using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Reference Objects for playable Heroes
*/
[CreateAssetMenu(fileName = "New Hero", menuName = "ScriptableObject/Hero/Empty Hero")]
public class MinionScriptableObject : ScriptableObject
{   
    /* -- Class types are out of scope 
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

    //Data Fields 
    [SerializeField] private new string name;
    public string Name {get {return name;}}

    [SerializeField] public string description;
    public string Description {get {return description;}}

    //VISUAL FIELDS
    [SerializeField] private Sprite artwork;
    public Sprite Artwork {get {return artwork;}}

    //AUDIO FIELDS  -- OUT OF SCOPE
    /*
    [SerializeField] private AudioClip summonSound;
    public AudioClip Artwork {get {return summonSound;}} //This needs to be better built out
    //public AudioClip attackSound;
    //public AudioClip deathSound;
    */

    //GAMEPLAY FIELDS
    [SerializeField] private int health;
    public int Health {get {return health;}}

    /* -- HERO POWER OUT OF SCOPE
    [SerializeField] private HeroPower health;
    public int Health {get {return health;}}
    */

    public GameObject ConvertToGameObject(){
        //Create the Hero Object? --> This should probably be done in the "in-game" hero Object.
    }

}
