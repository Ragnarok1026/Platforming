using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 60;
    int currentHealth;
    public Animator animator;
    public GameObject arrow;
    public GameObject Wall;


    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Boss defeated!");
    }
    
}
