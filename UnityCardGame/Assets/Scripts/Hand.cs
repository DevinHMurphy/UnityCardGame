using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;


public class Hand : MonoBehaviour {

    public Hand(){ 
    }

    private int maxHandSize = 10;

    public List<Card> hand = new List<Card>();


    public void AddCard(Card newCard){
        if(maxHandSize > hand.Count) {
            hand.Add(newCard);
            newCard.gameObject.transform.parent = this.gameObject.transform;
        }
        else {
            Debug.Log(name + "'s hand was too full!");
            //don't add and still remove from deck :)
        }
    }

    public void Remove(Card card){
        hand.Remove(card);
    }

    public int GetSize(){
        return hand.Count;
    }

    public void RemoveCardAt(int index){
        hand.RemoveAt(index);
    }

    public Card GetCard(int index){
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

    public void SetMaxHandSize(int limit){
        maxHandSize = limit;
    }

}