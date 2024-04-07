using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketballrespawn : MonoBehaviour
{
    // Store the original position of the basketball
    private Vector3 originalPosition;

    void Start()
    {
        // Save the original position when the script starts
        originalPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the basketball collided with an object tagged as "Floor"
        if (collision.gameObject.CompareTag("Floor"))
        {
            // Respawn the basketball back to its original position
            transform.position = originalPosition;
        }
    }
}
