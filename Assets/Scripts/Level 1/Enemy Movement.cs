using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject leftStop;
    public GameObject rightStop;
    public int Speed = 4;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);

        if (transform.position.x <= leftStop.transform.position.x)
        {
            Speed = -4;
        }
        else if (transform.position.x >= rightStop.transform.position.x)
        {
            Speed = 4;
        }
    }
}
