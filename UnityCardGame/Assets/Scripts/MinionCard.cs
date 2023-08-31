using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Extends card to create "in-game" Card that contains a minion.
*/
public class MinionCard : Card
{
        public enum PlayState{
        InDeck,
        InHand,
        InPlay
    }

    [SerializeField] public MinionScriptableObject minionSource; //Set in the Unity Editor
    private MinionScriptableObject gameplayMinion; //private, alterable version of the source

    private MinionCardDisplay minionCardDisplay; //Needs to be instantiated and on start()

    public CombatObject combatObject;

    private MinionCard.PlayState myPlayState;
    
    //Constructor
    public MinionCard(MinionScriptableObject minionSource){
        //set the card to have a minion cardType
        this.cardPlayType = CardPlayType.Minion;

        //Load a version of the minion for reading -- This is another level of security to ensure the original minion source is Never altered
        this.gameplayMinion = ScriptableObject.Instantiate(minionSource);

        this.name = gameplayMinion.Name;

        //construct the combatObject with the information from Scriptable Object
        this.combatObject = new CombatObject(this.gameplayMinion.Health, this.gameplayMinion.Health, this.gameplayMinion.Health, 0, 0, this.gameplayMinion.Attack, this.gameplayMinion.Attack);

        //Set the manaCost of the createdMinion Card -- OUT OF SCOPE

        //Create the display Object for the minion based on a created prefab
    }

    public MinionScriptableObject getGameplayMinion(){
        return this.gameplayMinion;
    }

    public MinionCard.PlayState getPlayState(){
        return this.myPlayState;
    }
    public void setPlayState(MinionCard.PlayState state){
        this.myPlayState = state;
    }

    public override void generateDisplay()
    {
        this.minionCardDisplay = new MinionCardDisplay(this);
    }

    public override void Start(){
        generateDisplay();
    }
}

