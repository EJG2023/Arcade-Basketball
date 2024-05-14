using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOverText; // Reference to the Game Over text
    public float totalTime = 120f;

    public float timeRemaining; // Changed access modifier from private to public
    private bool timerRunning = false;

    public AudioSource gameOverSound; // Reference to the AudioSource component for game over sound
    public Scoreboard scoreboard;

    void Start()
    {
        timeRemaining = totalTime;
        UpdateTimerDisplay();
    }
    
    // a function that updates
    void Update()
    {
        if (timerRunning)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();

            if (timeRemaining <= 0)
            {
                EndGame();
            }
        }
    }

    // function to start timer
    public void StartTimer()
    {
        timerRunning = true;
    }
    
    // function to display timer
    void UpdateTimerDisplay()
    {
        timerText.text = "" + Mathf.FloorToInt(timeRemaining).ToString();
    }
    
    // function to dictate "game over"
    void EndGame()
    {
        // Stop the timer
        timerRunning = false;
        
        // Play the game over sound
        if (gameOverSound != null)
        {
            gameOverSound.Play();
        }

        // Display "Game Over" text on the "GameOverText" component
        gameOverText.text = "Game Over";
    }

    // function to check if the timer is running
    public bool IsTimerRunning()
    {
        return timerRunning;
    }

    // function to add time
    public void AddTime(float additionalTime)
    {
        timeRemaining += additionalTime;
    }

    // function to fetch remaining time
    public float GetTimeRemaining()
    {
        return timeRemaining;
    }
}
