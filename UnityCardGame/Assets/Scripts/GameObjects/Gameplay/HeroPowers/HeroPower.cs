using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class HeroPower : MonoBehaviour
{
    //public combatEntity target;

    public new string name;
    public string description;

    public int cost;
    public int power;

    public abstract void Activate(Player target);    //combatEntity target
}