using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }
    public void Boss1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Boss 1");
    }
    public void Level2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 2");
    }
    public void Boss2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Boss 2");
    }
    public void Level3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 3");
    }
    public void Boss3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Boss 3");
    }
}
