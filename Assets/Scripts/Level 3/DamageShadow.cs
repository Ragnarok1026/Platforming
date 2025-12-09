using UnityEngine;

public class DamageShadow : MonoBehaviour
{
    public float bounce = 5f;
    public Rigidbody2D rb;
    public GameObject shadow;
    void Start()
    {
      
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shadow")
        {
            shadow.GetComponent<ShadowHealth>().TakeDamage(1);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
