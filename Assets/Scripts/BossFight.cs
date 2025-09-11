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
        yield return new WaitForSeconds(0.5f);
        rigidbody.gravityScale = 10;
        yield return new WaitForSeconds(1f);
        rigidbody.gravityScale = -1;
        yield return new WaitForSeconds(0.5f);
        while(transform.position.y < leftStop.transform.position.y)
        {
            yield return null;
        }
        if (rigidbody.gravityScale != 0)
        {
           rigidbody.gravityScale = 0;
        }

    }
}
