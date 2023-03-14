using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

//THIS HANDLES GAME EVENTS INSIDE ENCOUNTERS
public class GameManager : MonoBehaviour
{
    
    //STILL NEEDS TO BE BUILT OUT LOOK INTO HEARTHSTONE ANDVANCE PHASES
    public enum GameEvent{ //Player Actions build out phases later 
        game_start_phase,     //game initialized (this is a great to apply effects that start of game)
        pre_game,
        turn_start,     //a player has started turn
        turn_end,       //a player has ended turn
        card_played,    //any card played
        minion_summoned, //battlecry
        minion_damage,
        minion_death, 
        spell_played,
        player_death,
        effectPhase,
        afterPhase,
        game_end
    }

    public enum GameState{
        initialize,
        preGame,
        player1Turn,
        player2Turn,
        player1Victory,
        player2Victory,
        draw,

        aura_update, //aura updates health and attack of minions
        death_check,

    }

    public Player player1;
    public Player player2;

    public Player activePlayer;
    public Player inactivePlayer;

    public GameObject boardObj;
    public Board board;

    public GameState currentGameState;

    void Start() 
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
        //set the players to have the correct inital stats
        player1.InitalizeStats();
        player2.InitalizeStats();

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
        //inactivePlayer.addCardToHand(THECOIN) //***MAKE A COIN CARD
    }

    public void GameOutComeCheck(){
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


    public void Game(){
        switch (currentGameState){
            case GameState.initialize: //set stats and draw cards needed
                Debug.Log("The Game is initializing");
                StartGame();
                currentGameState = GameState.preGame;
                break;
            case GameState.preGame: //mulligan phase
                //mulligan
                SetTurn();
                break;
            case GameState.player1Turn:
                Debug.Log("Player 1's Turn Began");
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



