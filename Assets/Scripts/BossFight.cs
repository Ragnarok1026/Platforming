using UnityEngine;
using System.Collections;

public class BossFight : MonoBehaviour
{
    public GameObject player;
    public GameObject killTrigger;
    public GameObject leftStop;
    public GameObject rightStop;
    public Rigidbody2D rigidbody;
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
           speed = 0;
            StartCoroutine(Stomp());
        }
    }

   IEnumerator Stomp()
    {
        rigidbody.gravityScale = 1;
        yield return new WaitForSeconds(1f);
        while (transform.position.y < 18.64f)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            yield return null;

        }

    }
}
