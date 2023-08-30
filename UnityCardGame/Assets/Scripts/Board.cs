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
    public Map<String, Integer> boardLimit = new HashMap<String, Integer>();

    public Sprite boardStyle;

    //Constructor
    public Board(){
    }

    public void Start(){
        boardLimit.put("Player", 5);
        //boardLimit.put("Enemy", 5); //out of scope
    }

    public void AddToPlayerBoard(int index, GameObject gameObject){
        player1Board.Insert(index ,gameObject);
    }

    /*
    public void AddToEnemyBoard(int index, GameObject gameObject){
        player2Board.Insert(index ,gameObject);
    }
    */
}
