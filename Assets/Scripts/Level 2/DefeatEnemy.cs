using UnityEngine;

public class DefeatEnemy : MonoBehaviour
{
    public GameObject Door;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Door.GetComponent<NextRoom>().DefeatEnemy(1);
        }
        if (collision.CompareTag("Vulnerable"))
        {
            Door.GetComponent<NextRoom>().DefeatEnemy(1);
        }
    }
}
