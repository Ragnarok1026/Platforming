using JetBrains.Annotations;
using System.Collections;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Detects collision with player to load the next level
        if (collision.CompareTag("Player"))
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        // Load the scene named "Boss 1"
        SceneManager.LoadScene("Boss 1");
    }
}
