using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
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
        if(collision.gameObject.CompareTag("Boss"))
        {
            Debug.Log("Player hit by Boss");
            animator.SetBool("Death", true);
            Invoke("DisableMovement", 0.33f);
            player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
    void DisableMovement()
    {
        player.GetComponent<SpriteRenderer>().enabled = false;
        GameOverScreen();
    }

    public void GameOverScreen()
    {
        SceneManager.LoadScene("GameOver");
    }

}
