using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void gameStart()
    {
        Debug.Log("START");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
