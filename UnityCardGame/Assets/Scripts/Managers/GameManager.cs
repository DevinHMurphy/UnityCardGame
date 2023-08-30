using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/*
    This manages an "in-game" section of the game
*/
public class GameManager : MonoBehaviour //THIS WHOLE CLASS NEEDS TO BE-RE-WRITTEN
{
    public SceneManager sceneManager;

    public GameObject playerGameObject;
    private Player player;

    public GameObject combatManagerGameObject;
    public CombatManager combatmanager; 
    //ENEMY LOGIC GOES HERE


    //IN-Game Event Manager

    //Board Info
    public GameObject boardObj;
    private Board board;

    private GameState currentGameState;

    void Start() //Call this on load of the Scene
    {
        //Set the gamestate to initialize
        currentGameState = GameState.Initialize;
        
        /*
        boardObj = new GameObject("GameBoard");
        //set Board to be child of manager
        boardObj.transform.parent = this.gameObject.transform;
        board = boardObj.AddComponent<Board>();

        */
        Game();
    }

    //LOOK INTO A CLICK SYSTEM TARGETTING SYSTEM
    void Update() {
    }

    public void SetTurn() {
    }

    public void EndPlayerTurn() {
        currentGameState = GameState.PlayerEndPhase;
        //Do other end phase stuff here (project endPhase Signal)
    }

    public void StartGame(){
        //On start of game create all the neccessary components

        //Initialize Players
        player.InitalizeStats();

        //Initialize Decks

        //Initalize Enemies
        //Enemy.InitalizeStats();
        //Initialize Board & populate

        //roll Iniative! 
        //getInitiative()
    }

    public void GameOutComeCheck(){ //This checks for broadcast of potential Game-End Flags
        //check various bools if game status has concluded

        //check if Enemy CombatObject isDead

        //Check if Player CombatObject isDead
    }

    public void BeginPhase(){
        //Whose Turn is beginning 


            //Do something at the beginning Phase For Enemy

            //Do Something at the beginning Phase for Player (draw a card)
    }


    /* 
    return a list of gamePlayers in turn order
    */
    public Player getInitiative(){
        //Temp will make the player always be first (Later will return a list)
        return this.player;
    }


    public void Game(){ //Overall State Machine that tracks enacts the game state
        switch (currentGameState){
            case GameState.Initialize: //set stats and draw cards needed
                Debug.Log("The Game is initializing");
                StartGame();
                Debug.Log("The Game has finished initializing");
                //move the gameState
                currentGameState = GameState.PreGame;
                break;
            case GameState.PreGame:
                Debug.Log("Enter PreGame GameState");
                //The Mulligan goes here
                Debug.Log("Exit PreGame GameState");
                //V0 navigate to the player's turn
                currentGameState = GameState.PlayerBeginPhase;
                break;
            case GameState.PlayerBeginPhase:
                Debug.Log("Enter Player's BeginPhase");
                //Player begin phase 
                Debug.Log("Exit Player's BeginPhase");
                currentGameState = GameState.PlayerMainPhase;
                break;
            case GameState.PlayerMainPhase:
                Debug.Log("Enter Player's Main Phase GameState.");
                Debug.Log("Exit Player's Main Phase GameState.");
                break;
            case GameState.PlayerEndPhase:
                Debug.Log("Enter Player's Endphase.");
                Debug.Log("Exit Player's Endphase.");
                break;
            case GameState.EnemyBeginPhase:
                Debug.Log("Enter Player's BeginPhase");
                //Player begin phase 
                Debug.Log("Exit Player's BeginPhase");
                currentGameState = GameState.PlayerMainPhase;
                break;
            case GameState.EnemyrMainPhase:
                Debug.Log("Enter Player's Main Phase GameState.");
                Debug.Log("Exit Player's Main Phase GameState.");
                break;
            case GameState.EnemyEndPhase:
                Debug.Log("Enter Player's Endphase.");
                Debug.Log("Exit Player's Endphase.");
                break;
            case GameState.Draw:
                Debug.Log("The Game has ended in a Draw!");
                break;
            case GameState.PlayerVictory:
                Debug.Log("The Player has won the Game!");
                break;
            case GameState.EnemyVictory:
                Debug.Log("The Player has lost the Game!");
                break;
        }
    }
    public GameState getCurrentGameState(){
        return this.currentGameState;
    }
}

public enum GameState{
    Initialize,
    PreGame,
    PlayerBeginPhase,
    PlayerMainPhase,
    PlayerEndPhase,
    EnemyBeginPhase,
    EnemyrMainPhase,
    EnemyEndPhase,
    PlayerVictory,
    EnemyVictory,
    Draw
}


