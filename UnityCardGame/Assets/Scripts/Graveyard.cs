using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    The graveyard stores the references to minions defeated in combat,
*/
public class Graveyard : MonoBehaviour
{
    public List<GameObject> graveyard = new List<GameObject>();
    /** ENEMY BOARD -- OUT OF SCOPE
    public List<GameObject> enemyBoard = new List<GameObject>();
    */

    //Constructor
    public Graveyard(){
    }

    public void Start(){
    }

    public void AddToGraveyared(GameObject target){
        this.graveyard.Add(target);
    }
}
