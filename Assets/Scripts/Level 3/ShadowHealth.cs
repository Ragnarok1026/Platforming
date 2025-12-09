using UnityEngine;

public class ShadowHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float bounce;
    public Rigidbody2D rb;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
