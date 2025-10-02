using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen2 : MonoBehaviour
{
    public void ContinueGame()
    {
        LoadNextLevel();
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene("GameOver2");
    }
}
