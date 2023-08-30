using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    The Deck : MonoBehaviour class, is the "in-game" Deck manager and class.
    It handles all "in-game" actions the deck can undertake.
*/
public class Deck : MonoBehaviour
{

    public new string name; // QUESTION: This may be redundant and should be changed to a reference ID

    //public int size;
    //public List<Card> deck = new List<Card>();
    public DeckScriptableObject referenceDeck;

    private DeckScriptableObject gameplayDeck; 

    public List<Card> deck = new List<Card>();

    public List<Card> container = new List<Card>();
    
    private Card tempCard;

    //CONSTRUCTOR  
    public Deck(){

    }
    /*
    public Deck(DeckScriptableObject cosntructorDeck){
        referenceDeck = cosntructorDeck;
    }

    public void Start(){
        if(referenceDeck != null){
            //make a copy to protect original data
            gameplayDeck = ScriptableObject.Instantiate(referenceDeck);
        }
        if(gameplayDeck != null){
            //use card converter to create a deck to be used in play
            cardConverter = this.gameObject.AddComponent<CardConverter>();
            deck.AddRange(cardConverter.ConvertCards(gameplayDeck.Deck));
            name = gameplayDeck.Name;
        }

    }
    */

    public void generateDeck(DeckScriptableObject ReferenceDeck){
        referenceDeck = ReferenceDeck;
        if(referenceDeck != null){
            //make a copy to protect original data
            gameplayDeck = ScriptableObject.Instantiate(referenceDeck);
        }
        if(gameplayDeck != null){
          //convert the referenced cards into game-play cards
        }

    }


    public void Shuffle() {
        container.Add(deck[0]);
        for (int x = 0; x < deck.Count; x++) {
            //fill the container with the targetted card of the deck via index
            container[0] = deck[x];
            //generate a random value within the deck size, incrementing larger as objects are shuffled in
            int randomIndex = Random.Range(x, deck.Count);
            //set the indexed card in the deck to the card from the random index 
            deck[x] = deck[randomIndex];
            //place the container value that was originally deck[x] to the random index
            deck[randomIndex] = container[0];
        }
        Debug.Log(name + " Deck Shuffled");
        container.Clear();
    }

    public void RemoveAt(int index){
        deck.RemoveAt(index);
    }

    public void AddCard(Card newCard){
        deck.Add(newCard);
    }

    public int GetSize(){
        return deck.Count;

    }

    public void UpdateDeckData(){

    }

    public Card Get(int index){
        return deck[index];
    }

    public List<Card> Discover(){ //get 3 random cards from the deck, add the selected to the player's hand
        //if the bottom card of the deck exists
        if (GetSize() > 0){ 
            int randomIndex1 = Random.Range(0, deck.Count);
            container.Add(deck[randomIndex1]);
        }
        //if the 2nd bottom card of the deck exists
        if(GetSize() >1){ 
            int randomIndex2 = Random.Range(0, deck.Count);
            container.Add(deck[randomIndex2]);
        }
        //if the 3rd bottom card of the deck exists
        if(GetSize() >2){
            int randomIndex3 = Random.Range(0, deck.Count);
            container.Add(deck[randomIndex3]);
        }
        return container;

    }

    public List<Card> Dredge(){ //Look at the bottom 3 cards of the deck, put the chosen one on top
        //if the bottom card of the deck exists
        if (GetSize() > 0){ 
            container.Add(deck[GetSize()]);
        }
        //if the 2nd bottom card of the deck exists
        if(GetSize() >1){ 
            container.Add(deck[GetSize()- 1]);
        }
        //if the 3rd bottom card of the deck exists
        if(GetSize() >2){
            container.Add(deck[GetSize()- 2]);
        }
        return container;
    }


    public Card DrawCard(){
        //check if the deck has a card to draw
        if(deck.Count > 0){
            Debug.Log(name + " drew a " + deck[0].name);
            //hold the drew card inside temp
            tempCard = deck[0];
            //remove the drew card from the list 
            deck.RemoveAt(0);
            // return the temporary card
            return tempCard;
        }
        else {
            //if there is no card to be drawn return a null value
            return null;
        }
    }


}
