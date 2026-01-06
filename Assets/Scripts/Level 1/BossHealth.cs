using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public int speed = 8;
    public Collider2D bossCollider;
    public Animator animator;
    public GameObject oldLeft;
    public GameObject oldRight;
    public GameObject newLeft;
    public GameObject newRight;
    public GameObject target;
    public GameObject newTarget;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        animator.SetTrigger("Hurt");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            animator.SetBool("isDead", true);
            Die();
        }
        else
        {
            animator.SetBool("isDead", false);
        }
    }
    void Die()
    {
        Destroy(bossCollider);
        if (transform.position.x <= oldLeft.transform.position.x)
        {
            speed = -8;
        }
        else if (transform.position.x >= oldRight.transform.position.x)
        {
            speed = 8;
        }
        oldLeft.transform.position = newLeft.transform.position;
        oldRight.transform.position = newRight.transform.position;
        GetComponent<BossGoUp>().Speed = 2;
        Invoke("BossDeath", 2);
    }
    void BossDeath()
    {
        GetComponent<BossGoUp>().Speed = 2;
        target.transform.position = newTarget.transform.position;
    }
}
