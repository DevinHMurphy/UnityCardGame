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
        currentHandSize = hand.GetSize();
        for(int i = 0; i < handDisplay.Count; i++){
               if( i <currentHandSize){
                    if (!handDisplay[i].activeSelf){
                        handDisplay[i].SetActive(true);
                        card = hand.GetCard(i);
                        if(card is MinionCard){
                            mc = hand.GetCard(i);
                            handDisplay[i].GetComponent<MinionCardDisplay>().SetCard(mc);
                        }                        
                    }
                    else {

                    }
               }
               else{
                handDisplay[i].SetActive(false);
               }
        }
        //gameObject.SetActive(false);
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
