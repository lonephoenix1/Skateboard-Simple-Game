using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f; 
    [SerializeField] float boostSpeed = 40f; 
    [SerializeField] float normalSpeed = 20f; 
    Rigidbody2D rb2d; 
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>(); 
    }


    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow)) // If the up arrow key is pressed
        {
            surfaceEffector2D.speed = boostSpeed; // Increase surface speed for boosting
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed; // Set surface speed to normal when not boosting
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) // If the left arrow key is pressed
        {
            rb2d.AddTorque(torqueAmount); // Apply torque to rotate the player object clockwise
        }
        else if (Input.GetKey(KeyCode.RightArrow)) // If the right arrow key is pressed
        {
            rb2d.AddTorque(-torqueAmount); // Apply torque to rotate the player object counterclockwise
        }
    }
}

