using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 60;
    int currentHealth;
    public Animator animator;
    public GameObject arrow;

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
        Destroy(gameObject);
        Invoke("LoadWinScene", 0.5f);
    }

    void LoadWinScene()
    {
        arrow.SetActive(true);
    }
}
