using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI displayScore;


    // Update is called once per frame
    void Update()
    {
        DisplayScore();
    }

    public void DisplayScore()
    {
        displayScore.text = "Score: " + score;
    }
}
