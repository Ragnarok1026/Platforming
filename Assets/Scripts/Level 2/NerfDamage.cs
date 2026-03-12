using UnityEngine;

public class NerfDamage : MonoBehaviour
{
    public GameObject attack;
    public GameObject boss;
    public Rigidbody2D rb;
    public float bounce = 5f;
    public bool isNerfed;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Debuff"))
        {
            Debug.Log("Nerf hit");
            attack.GetComponent<DamageBoss>().enabled = false;
            isNerfed = true;

        }
            if (collision.gameObject.tag == "Boss2" && isNerfed)
            {
                Debug.Log("Boss hit");
                boss.GetComponent<Boss2Health>().TakeDamage(1);
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounce);
            }
    }
}
