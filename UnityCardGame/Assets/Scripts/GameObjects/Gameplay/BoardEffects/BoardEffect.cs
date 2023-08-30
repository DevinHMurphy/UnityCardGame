using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BoardEffect : MonoBehaviour //THIS FEATURE IS OUT OF SCOPE AND WILL BE IMPLEMENTED AT A LATER DATE
{
    
    public new string name;
    public string description;

    public int length;

    public bool isDefault;

    public abstract void Effect();
}
