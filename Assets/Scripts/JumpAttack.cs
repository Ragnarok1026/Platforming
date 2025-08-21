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
        if (other.CompareTag("Basic Square"))
        {
            Destroy(other.gameObject);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
