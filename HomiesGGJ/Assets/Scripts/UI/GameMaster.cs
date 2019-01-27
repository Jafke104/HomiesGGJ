using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public int points;

    public Text pointsText;

    private void Update()
    {
        pointsText.text = ("Points: " + points);
        
    }
}
