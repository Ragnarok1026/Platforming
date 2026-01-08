using UnityEngine;
using UnityEngine.SceneManagement;

public class DamagePlayer : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Detects collision with Boss to trigger player death
        if (collision.gameObject.tag == "Boss")
        {
            // Trigger death animation
            animator.SetBool("Death", true);
            // Disable player movement after a short delay
            Invoke("DisableMovement", 0.33f);
            // Disable player movement
            player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
    void DisableMovement()
    {
        // Disable player sprite and show game over screen
        player.GetComponent<SpriteRenderer>().enabled = false;
        // Hide player sprite
        GameOverScreen();
    }
    public void GameOverScreen()
    {
        // Load the Game Over scene
        SceneManager.LoadScene("GameOver 1");
    }
}
