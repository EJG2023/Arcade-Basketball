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

    public void StartTimer()
    {
        timerRunning = true;
    }

    void UpdateTimerDisplay()
    {
        timerText.text = "" + Mathf.FloorToInt(timeRemaining).ToString();
    }

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

    public bool IsTimerRunning()
    {
        return timerRunning;
    }

    // Method to add time
    public void AddTime(float additionalTime)
    {
        timeRemaining += additionalTime;
    }

    public float GetTimeRemaining()
    {
        return timeRemaining;
    }
}
