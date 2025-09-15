using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverBoss : MonoBehaviour
{
    void Update()
    {
        
    }

    public void ContinueGame()
    {
        LoadNextLevel();
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene("Boss Level 1");
    }
}
