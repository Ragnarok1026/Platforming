using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject pauseMenu;
    void Start()
    {
        pauseMenu.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf)
            {
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
            }
            else
            {
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
            }
        }
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
