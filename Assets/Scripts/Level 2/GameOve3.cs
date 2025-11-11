using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver3 : MonoBehaviour
{
    public void ContinueGame()
    {
        LoadNextLevel();
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene("Boss 2");
    }
}
