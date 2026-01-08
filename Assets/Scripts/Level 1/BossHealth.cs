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
    public GameObject Player;
    public GameObject oldLeft;
    public GameObject oldRight;
    public GameObject newLeft;
    public GameObject newRight;
    public GameObject target;
    public GameObject newTarget;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Narrator1;
    public GameObject Narrator2;
    public GameObject Narrator3;
    public GameObject Exit;
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
        GetComponent<BossGoUp>().Speed = 2;
        // Move target to new position
        Invoke("BossDeath", 2);
    }
    void BossDeath()
    {
        // Start boss ascent after death
        GetComponent<BossGoUp>().Speed = 8;
        target.transform.position = newTarget.transform.position;
        Invoke("purify1", 1.5f);
    }
    void purify1()
    {
        animator.SetInteger("Purify", 1);
        Text1.SetActive(true);
        Invoke("purify2", 4f);
    }
    void purify2()
    {
        animator.SetInteger("Purify", 2);
        Text1.SetActive(false);
        Text2.SetActive(true);
        Invoke("purify3", 4f);
    }
    void purify3()
    {
        animator.SetInteger("Purify", 3);
        Text2.SetActive(false);
        Text3.SetActive(true);
        Invoke("purify4", 4f);
    }
    void purify4()
    {
        animator.SetInteger("Purify", 4);
        Text3.SetActive(false);
        Text4.SetActive(true);
        Invoke("Final", 5);
    }
    void Final()
    {
        Text4.SetActive(false);
        Exit.SetActive(false);
        GetComponent<SpriteRenderer>().enabled = false;
        Narrator1.SetActive(true);
        StartCoroutine(EndOfTutorial());
    }
    IEnumerator EndOfTutorial()
    {
        while (cutscene1Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("Part1", 0f);
                cutscene1Started = true;
            }
            yield return null;
        }
        while (cutscene2Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene2Started == false)
            {
                Invoke("Part2", 0f);
                cutscene2Started = true;
            }
            yield return null;
        }
        while (cutscene3Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene3Started == false)
            {
                Invoke("End", 0f);
                cutscene3Started = true;
            }
            yield return null;
        }
    }
    void Part1()
    {
        Narrator1.SetActive(false);
        Narrator2.SetActive(true);
    }
    void Part2()
    {
        Narrator2.SetActive(false);
        Narrator3.SetActive(true);
    }
    void End()
    {
        Narrator3.SetActive(false);
        Player.GetComponent<PlayerMovement>().enabled = true;
    }
}
