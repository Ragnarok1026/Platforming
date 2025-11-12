using UnityEngine;

public class AttackBoss : MonoBehaviour
{
    public float bounce = 30f;
    public Rigidbody2D rb;
    public GameObject boss;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss"))
        {
            boss.GetComponent<BossHealth>().TakeDamage(10);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
