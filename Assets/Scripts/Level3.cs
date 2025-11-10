using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Level 3");
    }
}
