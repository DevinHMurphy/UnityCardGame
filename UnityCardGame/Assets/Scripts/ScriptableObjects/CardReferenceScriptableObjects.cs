using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardReferenceScriptableObjects : ScriptableObject //THIS IS REDUNDANT AND WILL BE REMOVED
{
   [SerializeField] private string index;
    public string Index {get {return index;}}

    [SerializeField] private CardType cardType;
    public CardType CardType {get {return cardType;}}

    public abstract GameObject ConvertToCard();  
}
