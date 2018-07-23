using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour {

    const float curr_z = -35.4f;
    public Transform player;
    public Text scoreText;
    float lastScore;
	
	// Update is called once per frame
	void Update () {
        try
        {
            lastScore = (player.position.z - curr_z);
            scoreText.text = lastScore.ToString("0");
        }
        catch (Exception e)
        {
            Debug.Log("SCORE SCRIPT! ");
            Debug.Log(e.Message);
        }
		
	}
}
