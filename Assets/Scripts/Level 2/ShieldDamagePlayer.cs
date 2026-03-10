using UnityEngine;
using UnityEngine.SceneManagement;

public class ShieldDamagePlayer : MonoBehaviour
{
    public Animator animator;
    public GameObject Cam;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shield"))
        {
            Invoke("DisableMovement", 0);
        }
    }
    void DisableMovement()
    {
        animator.SetBool("Death", true);
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        Invoke("GameOverScreen", 0.33f);
    }
    public void GameOverScreen()
    {
        SceneManager.LoadScene("GameOver3");
    }
}
