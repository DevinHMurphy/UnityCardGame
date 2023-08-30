using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

/*
    The hand class contains all the logic for "in-game" 
    Hand mechanics. 
*/

public class Hand : MonoBehaviour {

    private int maxHandSize = 10;
    public List<GameObject> hand = new List<GameObject>();

    public Hand(){ 
    }

    public void AddCard(GameObject newCard){
        if(maxHandSize > hand.Count) {
            hand.Add(newCard);
            newCard.gameObject.transform.parent = this.gameObject.transform;
        }
        else {
            //Hand is too full, --> Card is not added 
            Debug.Log(name + "'s hand was too full!");
        }
    }

    public void Remove(GameObject card){
        hand.Remove(card);
    }

    public int GetSize(){
        return hand.Count;
    }

    public void RemoveCardAt(int index){
        hand.RemoveAt(index);
    }

    public GameObject GetCard(int index){
        return hand[index];
    }

    public void DiscardCard(int index){
        hand.RemoveAt(index);
    }

    public void DiscardRandomCard(int numberOfCards){
        for(int i = 0; i < numberOfCards; i++){
            DiscardRandomCard();
        }
    }

    public void DiscardRandomCard(){
        hand.RemoveAt(Random.Range(0,hand.Count));
    }

    //Change the cardLimit of a Hand
    public void SetMaxHandSize(int limit){
        maxHandSize = limit;
    }

}