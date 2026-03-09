using UnityEngine;
using UnityEngine.SceneManagement;

public class HitByArrow : MonoBehaviour
{
    public GameObject arrow;
    public Animator animator;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            Debug.Log("Player hit by Arrow");
            Invoke("DisableMovement", 0.33f);
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
