using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    public Scoreboard scoreboard; // Reference to the scoreboard script
    public Timer timer; // Reference to the timer script

    public AudioSource scoreSound; // Reference to the AudioSource component for the score sound

    void Start()
    {
        // Disable the renderer component
        gameObject.GetComponent<Renderer>().enabled = false;
    }
    
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the basketball
        if (other.CompareTag("Basketball"))
        {
            // Check if the timer is still running
            if (timer.IsTimerRunning())
            {
                // Increment the score on the scoreboard
                scoreboard.IncrementScore();

                // Play the score sound
                if (scoreSound != null)
                {
                    scoreSound.Play();
                }
            }
        }
    }
}
