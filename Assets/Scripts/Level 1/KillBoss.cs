using UnityEngine;

public class KillBoss : MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb;
    public GameObject boss;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss"))
        {
            boss.GetComponent<BossHealth>().TakeDamage(20);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
