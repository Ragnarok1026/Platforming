using UnityEngine;

public class DamageBoss : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boss2")
        {
            Boss.GetComponent<Boss2Death>().TakeDamage(1);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
        }
    }
}
