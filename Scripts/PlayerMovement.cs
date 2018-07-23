using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {

    // Instance of the rigid body
    

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 6000f;
    public float jumpForce = 3000f;
    public float endGameHeight = -11f;
    bool fellLogged = false;
    // Debugging Console: Debug.
    
	
	// Update is called once per frame
	void FixedUpdate () {
        try
        {
            // UnOptimized Code
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                Debug.Log("QUIT ESC");
            }

            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-1 * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            //No Else If to handle the case where Left and Right are pressed together
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            else if (Input.GetKey("g"))
            {
                rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }

            if (rb.position.y < endGameHeight)
            {
                if (!fellLogged)
                {
                    Debug.Log("FELL OFF");
                    fellLogged = true;
                }
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        catch (Exception e)
        {
            Debug.Log("PLAYER MOVEMENT SCRIPT!!!!!!! ");
            Debug.Log(e.Message);
        }

        // Optimized Code
	    
	}
}
