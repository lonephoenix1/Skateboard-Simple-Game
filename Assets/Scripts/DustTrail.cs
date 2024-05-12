using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles; 

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the "Ground" tag
        if (collision.gameObject.tag == "Ground")
        {
            dustParticles.Play(); // Start emitting dust particles when colliding with the ground
        }
    }

    
    void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the colliding object has the "Ground" tag
        if (collision.gameObject.tag == "Ground")
        {
            dustParticles.Stop(); // Stop emitting dust particles when leaving the ground
        }
    }
}

