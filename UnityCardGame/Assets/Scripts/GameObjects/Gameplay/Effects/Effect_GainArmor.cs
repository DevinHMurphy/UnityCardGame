using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_GainArmor : Effect
{
    
    [SerializeField] private int procAmount = 1;

    [SerializeField] private int power = 1;

    public override void effect(){
        Debug.Log(this.target + "  was given " + power + " armor by an effect");
    }

}