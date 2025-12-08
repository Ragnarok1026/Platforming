using UnityEngine;

public class ShadowHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float bounce;
    public Rigidbody2D rb;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
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
