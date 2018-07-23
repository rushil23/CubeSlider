using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool gameEnded = false;
    public float timeDelay = 1.2f;
    public GameObject LevelCompleteUI;
    public Text LevelText;

    public void LevelComplete()
    {
        LevelText.text = "LEVEL " + (SceneManager.GetActiveScene().buildIndex).ToString();
        Debug.Log("CLEARED LEVEL " + SceneManager.GetActiveScene().buildIndex.ToString());
        LevelCompleteUI.SetActive(true);
        
    }

	public void EndGame()
    {
        if (gameEnded == false)
        {

            Debug.Log("ENDGAME");
            gameEnded = true;
            Invoke("Restart", timeDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
