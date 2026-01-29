using UnityEngine;

public class Boss2Death : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
