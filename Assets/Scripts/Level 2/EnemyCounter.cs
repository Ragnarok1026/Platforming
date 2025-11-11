using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public GameObject door;
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            door.GetComponent<OpenDoor>().EnemyDefeated(1);
        }
    }
}
