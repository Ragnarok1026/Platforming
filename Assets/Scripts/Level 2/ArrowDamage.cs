using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowDamage : MonoBehaviour
{
    private Animator animator;
    public GameObject player;
    public GameObject arrow;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit by Arrow");
            animator.SetBool("Death", true);
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            Invoke("Death", 0.33f);
        }
    }
    void Death()
    {
        SceneManager.LoadScene("GameOver3");
    }
}
