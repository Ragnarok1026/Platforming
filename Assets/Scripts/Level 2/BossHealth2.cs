using UnityEngine;

public class BossHealth2 : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    public GameObject teleportEffect;
    public GameObject teleportPoint1;
    public GameObject teleportPoint2;
    public GameObject teleportPoint3;
    public GameObject teleportPoint4;
    public GameObject shield;
    public float shieldSpeed = 180;
    public bool isDead = false;
    public GameObject boss;
    void Start()
    {
        currentHealth = maxHealth;
        
    }
    void Update()
    {
        if (currentHealth <= maxHealth)
        {
            shield.transform.Rotate(Vector3.forward * shieldSpeed * Time.deltaTime);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            isDead = true;
        }
        if(isDead == true)
        {
            teleportEffect.SetActive(true);
            Invoke("Die", 0.1f);
        }
        if (currentHealth == 20)
        {
            teleportEffect.SetActive(true);
            Invoke("BossPhase2Starts", 0.1f);
        }
        if (currentHealth == 10)
        {
            teleportEffect.SetActive(true);
            Invoke("BossPhase3Starts", 0.1f);
        }
    }
    void BossPhase2Starts()
    {
        transform.position = teleportPoint2.transform.position;
        teleportEffect.SetActive(false);
        boss.SetActive(true);
    }
    void BossPhase3Starts()
    {
        transform.position = teleportPoint3.transform.position;
        teleportEffect.SetActive(false);
        boss.SetActive(true);
    }
     void Die()
    {
        transform.position = teleportPoint4.transform.position;
        teleportEffect.SetActive(false);
        boss.SetActive(true);
        boss.GetComponent<Collider2D>().enabled = false;
    }
}
