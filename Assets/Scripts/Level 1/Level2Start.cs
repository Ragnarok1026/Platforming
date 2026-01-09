using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Start : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Overworld");
        }
    }
}
