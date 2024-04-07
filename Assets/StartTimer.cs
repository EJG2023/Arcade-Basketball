using UnityEngine;
using TMPro;
using UnityEngine.XR;


public class StartTimerOnKeyPress : MonoBehaviour
{
    // Reference to the Timer script
    public Timer timer; 
    public TextMeshProUGUI gameOverText;
    public OVRInput.Button AButton = OVRInput.Button.One;
    public Scoreboard scoreboard;
    public AudioSource startSound;

    void Update()
    {
        // Check if the A button is pressed
        if (OVRInput.GetDown(AButton))
        {
            // Check if the timer is not running or has ended
            if (!timer.IsTimerRunning() || timer.GetTimeRemaining() <= 0)
            {
                // Reset the timer to its initial value
                timer.timeRemaining = timer.totalTime;
                timer.StartTimer();
                gameOverText.text = "";
                scoreboard.ResetScore();
                
                if (startSound != null)
                {
                    startSound.Play();
                }
            }
        }
    }
}
