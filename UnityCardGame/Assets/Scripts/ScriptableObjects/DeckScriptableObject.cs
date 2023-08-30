using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Deck")]
public class DeckScriptableObject : ScriptableObject
{
    // Start is called before the first frame update

    [SerializeField] private new string name;
    public string Name {get {return name;}}


    [SerializeField] private List<ScriptableObject> deck = new List<ScriptableObject>();
    public List<ScriptableObject> Deck {get {return deck;}}

    /*
    [SerializeField] private List<Card> deck = new List<Card>();
    public List<Card> Deck {get {return deck;}}
    */
}
