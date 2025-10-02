using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox2 : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
    public static bool isDead = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && !isDead)
        {
            animator.SetBool("Death", true);
            Invoke("DisableMovement", 0.33f);
            Player.GetComponent<PlayerMovement>().enabled = false;
        }

    }
    void DisableMovement()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen();
    }

    public void GameOverScreen()
    {
        SceneManager.LoadScene("GameOver");
    }
}
