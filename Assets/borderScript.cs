using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Disable the renderer component for the border above the machine so that it wont get stuck and make it invisible
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
