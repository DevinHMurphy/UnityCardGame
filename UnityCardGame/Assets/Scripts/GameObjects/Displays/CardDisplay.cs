using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class CardDisplay : MonoBehaviour
{
 
    public abstract void Render();

    public abstract Card GetCard();

    public abstract void SetCard(Card input); //NEEDS TO UPDATED LATER


    


}
