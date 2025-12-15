using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
    public static bool isDead = false;
    private void OnCollisionEnter2D(Collision2D collision)  
    {
        if (collision.gameObject.tag == "Enemy1" &&  !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement1", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
        if (collision.gameObject.tag == "Enemy2" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement2", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
        if (collision.gameObject.tag == "Vulnerable" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement3", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
        if (collision.gameObject.tag == "Helmet" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement3", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Arrow" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement2", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
    void DisableMovement1()
       {
            Player.GetComponent<SpriteRenderer>().enabled = false;
            GameOverScreen1();
        }

    public void GameOverScreen1()
    {
        SceneManager.LoadScene("GameOver");
    }

    void DisableMovement2()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen2();
    }

    public void GameOverScreen2()
    {
        SceneManager.LoadScene("GameOver 1");
    }
    
    public void DisableMovement3()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen3();
    }

    public void GameOverScreen3()
    {
        SceneManager.LoadScene("GameOver3");
    }
}
