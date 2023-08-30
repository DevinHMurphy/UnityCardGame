using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HandDisplay : MonoBehaviour
{
    public Hand hand; 
    private Card card;
    private MinionCard mc;

    private int currentHandSize;
    public List<GameObject> handDisplay = new List<GameObject>();

    private CardDisplay cardDisplay;


    public void SetHand(Hand input){
        this.hand = input;
    }

    public void UpdateInfo(){
        //update the the display of all cards inside the hand

        //get each card in the hand

        //update its display
    }
    public void Render()
    {
        UpdateInfo();
        currentHandSize = hand.GetSize();
        foreach(GameObject cardDisplayObject in handDisplay){
            cardDisplay = cardDisplayObject.GetComponent<CardDisplay>();
            if(cardDisplay.GetCard() != null){
                cardDisplay.Render();
            }
        }
    }

    void Update(){
        Render();
    }
}
