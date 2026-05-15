using UnityEngine;

public class Boss3Start : MonoBehaviour
{
    public ShadowHealth healthScript;
    public GameObject player;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            healthScript.textBox.SetActive(true);
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            healthScript.Animate();
        }
    }
}
