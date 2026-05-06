using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public int speed = 8;
    public bool cutscene1Started = false;
    public bool cutscene2Started = false;
    public bool cutscene3Started = false;
    public Collider2D bossCollider1;
    public Collider2D bossCollider2;
    public Animator animator;
    public GameObject Cam;
    public GameObject Player;
    public GameObject oldLeft;
    public GameObject oldRight;
    public GameObject newLeft;
    public GameObject newRight;
    public GameObject target;
    public GameObject newTarget;
    public GameObject newDeath;
    public GameObject Exit;
    public GameObject bossTextBox;
    public BossText bossText;

    void Start()
    {
        // Initialize current health to maximum health
        currentHealth = maxHealth;
    }
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        // Trigger hurt animation and reduce health
        animator.SetTrigger("Hurt");
        // Reduce current health by damage amount
        currentHealth -= damage;
        // Check if health has dropped to zero or below
        if (currentHealth <= 0)
        {
            Cam.GetComponent<AudioSource>().Stop();
            animator.SetBool("isDead", true);
            Die();
        }
        // If still alive, ensure isDead is false
        else
        {
            animator.SetBool("isDead", false);
        }
    }
    void Die()
    {
        Player.GetComponent<PlayerMovement>().enabled = false;
        Player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        // Disable boss collider and handle death behavior
        Destroy(bossCollider1);
        Destroy(bossCollider2);
        // Change movement boundaries upon death
        if (transform.position.x <= oldLeft.transform.position.x)
        {
            speed = -8;
        }
        else if (transform.position.x >= oldRight.transform.position.x)
        {
            speed = 8;
        }
        // Move boundaries to new positions
        oldLeft.transform.position = newLeft.transform.position;
        // Move boundaries to new positions
        oldRight.transform.position = newRight.transform.position;
        // Start boss ascent after death
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (transform.position.y >= newDeath.transform.position.y)
        {
            transform.position = newTarget.transform.position;
            speed = 0;
        }
        Invoke("DeathCutscene", 1f);
    }
    void DeathCutscene()
    {
        bossTextBox.SetActive(true);
        bossText.ShowText();
    }
}
