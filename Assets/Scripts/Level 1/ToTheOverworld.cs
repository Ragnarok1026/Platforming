using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheOverworld : MonoBehaviour
{
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Detects collision with player to load the overworld level
        if (collision.CompareTag("Player"))
        {
            LoadNextLevel();
        }
    }
    // Loads the scene named "Overworld"
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Overworld");
    }
}
