using UnityEngine;

public class JumpAttack2 : MonoBehaviour
{
    public float bounce;
    public Rigidbody2D rb;
    public GameObject Enemy;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            GetComponent<NextRoom>().DefeatEnemy(1);
        }
    }
}
