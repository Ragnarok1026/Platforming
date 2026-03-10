using UnityEngine;

public class DamageBoss : MonoBehaviour
{
    public float bounce = 20f;
    public GameObject Boss;
    public Rigidbody2D rb;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Detects collision with Boss to apply damage
        if (collision.gameObject.tag == "Boss2")
        {
            Boss.GetComponent<Boss2Health>().TakeDamage(5);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
