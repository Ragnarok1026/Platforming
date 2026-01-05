using UnityEngine;
using UnityEngine.UI;

public class DamageKing : MonoBehaviour
{
    public float bounce = 5f;
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
        if (collision.gameObject.tag == "Boss")
        {
            Boss.GetComponent<BossHealth>().TakeDamage(1);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
