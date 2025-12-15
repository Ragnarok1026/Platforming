using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadNextLevel2();
        }
    }
    public void LoadNextLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
