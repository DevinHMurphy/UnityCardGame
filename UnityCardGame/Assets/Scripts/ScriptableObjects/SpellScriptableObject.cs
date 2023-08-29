using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Minion", menuName = "ScriptableObject/Generic Minion")]
public class SpellScriptableObject : CardReferenceScriptableObjects
{
    private GameObject cardObj;

    [SerializeField] private List<Effect> spellEffects = new List<Effect>();

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

    [SerializeField] private Sprite artwork;
    public Sprite Artwork {get {return artwork;}}

    //public int defaultManaCost;
    [SerializeField] private int manaCost;
    public int ManaCost {get {return manaCost;}}

    public override GameObject ConvertToCard(){
        //TO BE IMPLEMENTED
        cardObj = new GameObject(this.Name +"_Card");
        //ouputCard.UpdateMinionCard(this.Name, this.Description, this.Index, this.Artwork, this.Health, this.Attack, this.ManaCost);  
        return cardObj;
    }



}
