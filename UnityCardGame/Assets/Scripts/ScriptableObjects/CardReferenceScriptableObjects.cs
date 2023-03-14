using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardReferenceScriptableObjects : ScriptableObject
{
   [SerializeField] private string index;
    public string Index {get {return index;}}

    public abstract GameObject ConvertToCard();  
}
