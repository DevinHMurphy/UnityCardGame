using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCard : Card
{
    //public scritable object used as reference but never altered
    [SerializeField] public SpellScriptableObject spellSource;

    //instantiated scriptableObject altered in gameplay
    private SpellScriptableObject gameplaySpell;
    
    public GameObject displayPrefab;

    public override void generateDisplay()
    {

    }

    public override void Start(){
        generateDisplay();
    }


}
