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
    public GameObject energyPoint1;
    public GameObject energyPoint2;
    public GameObject energyPoint3;
    public GameObject energyPoint4;
    public GameObject shield;
    public GameObject energy1;
    public GameObject energy2;
    public float shieldSpeed = 180;
    public bool isDead = false;
    public GameObject boss;
    public EnergyLeft energyLeft;
    public Transform player;
    public StartBossCutscene cutscene;
    public float speed = 5.0f;
    void Start()
    {
        currentHealth = maxHealth;
        
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (currentHealth <= maxHealth)
        {
            shield.transform.Rotate(Vector3.forward * shieldSpeed * Time.deltaTime);
            if(cutscene.endCutscene == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
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
            energy1.transform.position = energyPoint1.transform.position;
            energy2.transform.position = energyPoint2.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            Invoke("BossPhase2Starts", 0.1f);
        }
        if (currentHealth == 10)
        {
            teleportEffect.SetActive(true);
            energy1.transform.position = energyPoint3.transform.position;
            energy2.transform.position = energyPoint2.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            Invoke("BossPhase3Starts", 0.1f);
        }
    }
    void BossPhase2Starts()
    {
        transform.position = teleportPoint2.transform.position;
        teleportEffect.SetActive(false);
        boss.SetActive(true);
        shield.SetActive(true);
        energy1.SetActive(true);
        energy2.SetActive(true);
        energyLeft.MaxEnergy = 3;
        speed = 5.0f;
    }
    void BossPhase3Starts()
    {
        transform.position = teleportPoint3.transform.position;
        teleportEffect.SetActive(false);
        boss.SetActive(true);
        shield.SetActive(true);
        energy1.SetActive(true);
        energy2.SetActive(true);
        energyLeft.MaxEnergy = 3;
        speed = 5.0f;
    }
    void Die()
    {
        transform.position = teleportPoint4.transform.position;
        teleportEffect.SetActive(false);
        boss.SetActive(true);
        boss.GetComponent<Collider2D>().enabled = false;
        speed = 0;
    }
}
