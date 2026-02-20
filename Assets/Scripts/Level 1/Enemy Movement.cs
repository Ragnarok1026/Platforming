using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject leftStop;
    public GameObject rightStop;
    public int Speed = 5;
    void Start()
    {
        
    }
    void Update()
    {
        // Move the enemy left or right based on the Speed variable
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
        // Check for direction change at the stop points
        if (transform.position.x <= leftStop.transform.position.x)
        {
            Speed = -5;
            transform.localScale = new Vector3(7, 7, 7); // Flip the enemy sprite to face right
        }
        // Change direction when reaching the right stop point
        else if (transform.position.x >= rightStop.transform.position.x)
        {
            Speed = 5;
            transform.localScale = new Vector3(-7, 7, 7); // Flip the enemy sprite to face left
        }
    }
}
