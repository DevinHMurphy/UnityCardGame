using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    //public int boardIndex;

    public Player player1;

    public Player player2;

    public int player1BoardLimit = 5;

    public int player2BoardLimit = 5;
    
    public List<Minion> fullBoard = new List<Minion>();

    public List<Minion> player1Board = new List<Minion>();
    public List<Minion> player2Board = new List<Minion>();

    
    private List<Minion> container = new List<Minion>();

    //public BoardEffect defaultPlayer1BoardEffect = null;

    //public BoardEffect defaultPlayer2BoardEffect = null;

    public BoardEffect activePlayer1BoardEffect; //set to default when its created

    public BoardEffect activePlayer2BoardEffect; //set to default when its created

    public Sprite boardStyle;

    public Board(){

    }

    public void InitializeBoard(Player player1, Player player2){
        this.player1 = player1;
        this.player2 = player2;

        //apply board effects;
    }
    public void UdpateBoard() {
        //add both boards to the 
         List<Minion> tempList = new List<Minion>();
         tempList.AddRange(player1Board);
         tempList.AddRange(player2Board);
         //clear the board list
         fullBoard.Clear();
         //add the things into the list
         fullBoard.AddRange(tempList);
    }


    public void AddToPlayer1Board(int index, Minion m){
        player1Board.Insert(index ,m);
    }

    public void AddToPlayer2Board(int index, Minion m){
        player2Board.Insert(index ,m);
    }

    //public List<BoardEffect> boardEffects = new List<BoardEffect>();

    //public boolean isDefault;
    


}
