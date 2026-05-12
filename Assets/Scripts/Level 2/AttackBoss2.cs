using UnityEngine;

public class AttackBoss2 : MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb;
    public BossHealth2 bossHealth;
    public BossHealth2 health;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boss2"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
            if (bossHealth.currentHealth >= 0)
            {
                bossHealth.TakeDamage(10);
                health.speed = 0;

            }
        }
    }
}
