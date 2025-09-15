using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject leftStop;
    public GameObject rightStop;
    public int speed = 4;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= leftStop.transform.position.x)
        {
            speed = -2;
        }
        else if (transform.position.x >= rightStop.transform.position.x)
        {
            speed = 2;
        }
    }
}
