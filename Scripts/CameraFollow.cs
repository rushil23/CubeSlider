using UnityEngine;
using UnityEngine.SceneManagement; //For logging level name
using System;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    bool logged = false;
	
	// Update is called once per frame
	void Update () {
        try
        {
            transform.position = player.position + offset;
            if (!logged)
            {
                Debug.Log(SceneManager.GetActiveScene().name);
                logged = true;
            }
        }
        catch (Exception e)
        {
            Debug.Log("CAMERA FOLLOW SCRIPT ! !! ");
            Debug.Log(e.Message);
        }
	}
}
