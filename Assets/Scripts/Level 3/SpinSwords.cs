using UnityEngine;
using UnityEngine.SceneManagement;

public class SpinSwords : MonoBehaviour
{
    public float speed = 10f;
    public GameObject player;
    public Animator animator;
    public static bool isDead = false;
    void Start()
    {
        
    }

    void Update()
    {
        if(tag == "Swords1")
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        else if(tag == "Swords2")
        {
            transform.Rotate(Vector3.back * -speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
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
        SceneManager.LoadScene("GameOver5");
    }
}
