using UnityEngine;

public class BossFight : MonoBehaviour
{
    public GameObject player;
    public GameObject killTrigger;
    public GameObject leftStop;
    public GameObject rightStop;
    public int speed = 4;
    void Update()
    {
        if (transform.position.y >= leftStop.transform.position.y)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);

            if (transform.position.x <= leftStop.transform.position.x)
            {
                speed = -speed;
            }
            else if (transform.position.x >= rightStop.transform.position.x)
            {
                speed = -speed;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           speed = 0;
           Invoke("Stomp", 0.7f);
        }
    }

    void Stomp()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
