using UnityEngine;

public class EnterLevel : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<PlayerMovement>().enabled = true;
            Player.GetComponent<Rigidbody2D>().gravityScale = 2;
            Player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        }
    }
}
