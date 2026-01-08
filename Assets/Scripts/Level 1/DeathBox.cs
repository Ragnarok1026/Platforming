using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
    public static bool isDead = false;
    private void OnCollisionEnter2D(Collision2D collision)  
    {
        // Detects collision with different enemy types to trigger player death
        if (collision.gameObject.tag == "Enemy1" &&  !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement1", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
        // Detects collision with different enemy types to trigger player death
        if (collision.gameObject.tag == "Enemy2" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement2", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
        // Detects collision with different enemy types to trigger player death
        if (collision.gameObject.tag == "Vulnerable" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement3", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
        // Detects collision with different enemy types to trigger player death
        if (collision.gameObject.tag == "Helmet" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement3", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
    // Detects collision with arrows to trigger player death
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Arrow" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement2", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
    // Disables player movement and shows game over screen for Enemy1 collision
    void DisableMovement1()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen1();
    }
    // Loads the Game Over scene for Enemy1 collision
    public void GameOverScreen1()
    {
        SceneManager.LoadScene("GameOver");
    }
    // Disables player movement and shows game over screen for Enemy2 collision
    void DisableMovement2()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen2();
    }
    // Loads the Game Over scene for Enemy2 collision
    public void GameOverScreen2()
    {
        SceneManager.LoadScene("GameOver 1");
    }
    // Disables player movement and shows game over screen for Vulnerable and Helmet collision
    public void DisableMovement3()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen3();
    }
    // Loads the Game Over scene for Vulnerable and Helmet collision
    public void GameOverScreen3()
    {
        SceneManager.LoadScene("GameOver3");
    }
}
