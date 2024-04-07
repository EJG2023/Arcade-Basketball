using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollideSound : MonoBehaviour
{
    public AudioClip bounceSound;
    private AudioSource audioSource;

    void Start()
    {
        // At start of application set the sounds
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bounceSound;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision has enough velocity to play the sound
        if (collision.relativeVelocity.magnitude > 0.1f)
        {
            // Play the bounce sound
            audioSource.Play();
        }
    }
}
