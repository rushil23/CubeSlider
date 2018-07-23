using UnityEngine;
using System;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement pm;

    void OnCollisionEnter(Collision collision)
    {
        try
        {

            if (collision.collider.tag == "Obstacle")
            {
                pm.enabled = false;
                Debug.Log("COLLISION");
                FindObjectOfType<GameManager>().EndGame();
            }
        }
        catch (Exception e)
        {
            Debug.Log("THIS HAPPENED IN COLLISION SCRIPT");
            Debug.Log(e.Message);
        }

        
    }

}
