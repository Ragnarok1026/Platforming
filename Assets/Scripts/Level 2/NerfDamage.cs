using UnityEngine;

public class NerfDamage : MonoBehaviour
{
    public GameObject attack;
    public GameObject player;
    public GameObject boss;
    public Rigidbody2D rb;
    public float bounce = 5f;
    private SpriteRenderer spr;
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
            player.GetComponent<PlayerMovement>().runSpeed = 6;
            spr = GetComponent<SpriteRenderer>();
            spr.color = Color.green;
        }
    }
}
