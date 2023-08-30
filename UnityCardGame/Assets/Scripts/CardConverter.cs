using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    The card converter is an importable static class that 
    handles the conversion from Card's reference objects (Scriptable Objects)
    to the their "in-game" counterparts -- Data should be moved into Card itself
*/

public class CardConverter : MonoBehaviour
{
    public List<Card> outList = new List<Card>();  

    public GameObject temp;
    
    public CardConverter(){
    }

    public List<Card> ConvertCards( List<CardReferenceScriptableObjects> input, GameObject gameDeckObj){
        outList.Clear();
        for (int i = 0; i < input.Count; i++){
            temp = input[i].ConvertToCard();
            temp.transform.parent = gameDeckObj.transform;
            outList.Add(temp.GetComponent<Card>());
        }
        return outList;
    }

    /*
    public MinionCard ConvertToCard(MinionScriptableObject input){
        //create a Card GameObject
        GameObject cardObj = new GameObject(input.Name +"_Card");
        //set Board to be child of manager
        cardObj.transform.parent = this.gameObject.transform;
        board = boardObj.AddComponent<Board>();
        MinionCard temp = new MinionCard(input);
        return temp;
    }
    */

    public Card ConvertToCard(){
        return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
