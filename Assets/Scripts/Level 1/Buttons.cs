using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
