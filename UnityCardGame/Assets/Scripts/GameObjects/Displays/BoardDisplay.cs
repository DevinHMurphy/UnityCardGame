using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoardDisplay : MonoBehaviour
{
    public Board board;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image boardBackground;

    public TextMeshProUGUI length;

    public void Render()
    {
        nameText.text = board.name;
        boardBackground.sprite = board.boardStyle;
        
        //descriptionText.text = board.descriptionText;
    }
}
