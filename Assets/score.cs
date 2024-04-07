using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;

    private int score = 0;

    private int highScore = 0; // Variable to store the high score

    public Timer timer; // Reference to the Timer script


     // Method to initialize the scoreboard
    public void Initialize(Timer timerComponent)
    {
        timer = timerComponent;
    }

    public void IncrementScore()
    {
        score++;
        DisplayScore();
        timer.AddTime(5); // Increment time by 5 when the score increases

        if (score > highScore) // Check if the current score is greater than the high score
        {
            highScore = score; // Update the high score if the current score is greater
            DisplayHighScore();
        }
    }

    void DisplayScore()
    {
        scoreText.text = "" + score.ToString();
    }

    void DisplayHighScore()
    {
        scoreText2.text = "" + highScore.ToString();
    }
    
     public void ResetScore()
    {
        score = 0;
        DisplayScore();
    }
}   
