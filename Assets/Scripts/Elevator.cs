using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject Player;
    public GameObject elevator;
    public int speed = 10;
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            elevator.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}
