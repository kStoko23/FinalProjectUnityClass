using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{ 
    public int score = 0;
    public TextMeshProUGUI scoreDisplay;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }
}
