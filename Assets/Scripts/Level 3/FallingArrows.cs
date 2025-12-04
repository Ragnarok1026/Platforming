using UnityEngine;

public class FallingArrows : MonoBehaviour
{
    public GameObject arrow;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            arrow.GetComponent<Rigidbody2D>().gravityScale = 10;
        }
    }
}
