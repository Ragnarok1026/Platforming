using UnityEngine;

public class JumpAttack : MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy1"))
        {
            Destroy(other.gameObject);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
        if (other.CompareTag("Helmet"))
        {
            Destroy(other.gameObject);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
        if (other.CompareTag("Vulnerable"))
        {
            Destroy(other.gameObject);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
