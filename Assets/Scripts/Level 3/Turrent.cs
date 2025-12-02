using UnityEngine;

public class Turrent : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Target Locked");
            transform.LookAt(collision.transform);
        }
    }
}
