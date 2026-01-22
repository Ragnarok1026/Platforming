using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject boss;
    public Animator animator;
    public int speed = 4;
    public GameObject player;
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            Debug.Log("Player hit by Boss");
            animator.SetBool("Death", true);
            Invoke("DisableMovement", 0.33f);
            player.GetComponent<PlayerMovement>().enabled = false;
        }
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            Debug.Log("Player hit by Enemy");
            animator.SetBool("Death", true);
            Invoke("DisableMovement", 0.33f);
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            Debug.Log("Player hit by Boss");
            animator.SetBool("Death", true);
            Invoke("DisableMovement", 0.33f);
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        }
    }
    void DisableMovement()
    {
        player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen();
    }

    public void GameOverScreen()
    {
        SceneManager.LoadScene("GameOver3");
    }
}
