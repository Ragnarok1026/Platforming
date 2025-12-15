using UnityEngine;
using System.Collections;

public class BossFight : MonoBehaviour
{
    public GameObject player;
    public GameObject killTrigger;
    public GameObject leftStop;
    public GameObject rightStop;
    public new Rigidbody2D rigidbody; // Add 'new' keyword to explicitly hide inherited member
    public int speed = 4;

    public void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
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
            StartCoroutine(Stomp());
        }
    }

   IEnumerator Stomp()
    {
        speed = 0;
        yield return new WaitForSeconds(0.5f);
        rigidbody.gravityScale = 10;
        yield return new WaitForSeconds(1.4f);
        rigidbody.gravityScale = 0;
        speed = 8;
        while (transform.position.y < 18.64f)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            yield return null;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Player hit");
            speed = 0;
        }
    }
}
