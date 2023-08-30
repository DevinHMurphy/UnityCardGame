using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    //Board is Separated into sections for each player
    public List<GameObject> playerBoard = new List<GameObject>();

    /** ENEMY BOARD -- OUT OF SCOPE
    public List<GameObject> enemyBoard = new List<GameObject>();
    */

    //boardLimit Map stores the maximum unit count for the specific player or enemy
    public Dictionary<string, int> boardLimit = new Dictionary<string, int>();

    public Sprite boardStyle;

    //Constructor
    public Board(){
    }

    public void Start(){
        boardLimit.Add("Player", 5);
        //boardLimit.put("Enemy", 5); //out of scope
    }

    public void AddToPlayerBoard(int index, GameObject gameObject){
        playerBoard.Insert(index ,gameObject);
    }

    /*
    public void AddToEnemyBoard(int index, GameObject gameObject){
        player2Board.Insert(index ,gameObject);
    }
    */
}
