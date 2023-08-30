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


    void Start() //Call this on load of the Scene
    {
        //Set the gamestate to initialize
        currentGameState = GameState.initialize;
        //create a board GameObject
        boardObj = new GameObject("GameBoard");
        //set Board to be child of manager
        boardObj.transform.parent = this.gameObject.transform;
        board = boardObj.AddComponent<Board>();
        board.InitializeBoard(player1, player2);
        player1.InitializePlayer();
        player2.InitializePlayer();
        //Board board = new Board();
        Game();
    }

    //LOOK INTO A CLICK SYSTEM TARGETTING SYSTEM
    void Update() 
    {
    if(Input.GetKeyDown(KeyCode.Space))
    {
        player1.DrawCard();
    }
    if(Input.GetKeyDown(KeyCode.Return))
    {
        player1.PlayCard(0);
    }
    }

    public void SetTurn() {
        if (activePlayer == player1) {
            currentGameState = GameState.player1Turn;
        }
        else {
            currentGameState = GameState.player2Turn;
        }
    }

    public void EndTurn() {
        if (activePlayer == player1) {
            activePlayer = player2;
            currentGameState = GameState.player2Turn;
        }
        else {
            activePlayer = player1;
            currentGameState = GameState.player1Turn;
        }

    }

    public void StartGame(){
        //On start of game create all the neccessary components
        //Initialize Players

        //Initialize Decks

        //Initialize Board --> Is this a scene tranisition?
        player.InitalizeStats();
        Enemy.InitalizeStats();

        //Choose who goes first
        Random.Range(0,1);
        if (Random.value < .5){
            activePlayer = player1;
            inactivePlayer = player2;
        }else {
            activePlayer = player2;
            inactivePlayer = player1;
        }
        //draw cards for each player
        activePlayer.DrawCard(3);
        inactivePlayer.DrawCard(3);
    }

    public void GameOutComeCheck(){ //This checks for broadcast of potential Game-End Flags

        //check if a player has been defeated -- THIS LOGIC CAN BE CLEANED UP
        if (player1.health <= 0) {
            if (player2.health <= 0){
                currentGameState =  GameState.draw;
            } else{
                currentGameState = GameState.player2Victory;
            }
        }
        if(player2.health <=0){
            if(player1.health <= 0){
                currentGameState = GameState.draw;
            } else {
                currentGameState = GameState.player1Victory;
            }
        }
        //if both players have more than 0 health the game continues
    }

    public void BeginPhase(Player currentPlayer){

    }

    public Player getFirstplayer(){
        //This logic will defined at a later time (Speed test? Random? ETC.)
        //Temp will make the player always be first
        return this.player;
    }


    public void Game(){ //Overall State Machine that tracks enacts the game state
        switch (currentGameState){
            case GameState.initialize: //set stats and draw cards needed
                Debug.Log("The Game is initializing");
                StartGame();
                currentGameState = GameState.Pregame;
                break;
            case GameState.preGame:
                Debug.Log("The Game is About to Begin!");
                
                break;
            case GameState.PlayerBeginPhase:
                Debug.Log("Player 1's Turn Began");
                player.draw();
                break;
            case GameState.player2Turn:
                Debug.Log("Player 2's Turn Began");
                break;
            case GameState.player1Victory:
                Debug.Log("Player 1 Won!");
                break;
            case GameState.player2Victory:
                Debug.Log("Player 2 Won!");
                break;
            case GameState.draw:
                Debug.Log("The Game was a Draw!");
                break;
        }
    }
}

public enum GameState{
    Initialize,
    PreGame, //mulligan
    PlayerBeginPhase,
    PlayerMainPhase,
    PlayerEndPhase,
    EnemyBeginPhase,
    EnemyrMainPhase,
    EnemyEndPhase,
    PlayerVictory,
    EnemyVictory,
     //aura_update, //Update all the minions
}


