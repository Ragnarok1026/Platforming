using UnityEngine;
using System.Collections;

public class BossHealth2 : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    public float shieldSpeed = 180;
    public float speed = 5.0f;
    public float duration = 100f;
    public float magnitude = 0.1f;
    public bool isDead = false;
    public Transform player;
    public EnergyLeft energyLeft;
    public StartBossCutscene cutscene;
    public GameObject teleportEffect;
    public GameObject teleportPoint1;
    public GameObject teleportPoint2;
    public GameObject teleportPoint3;
    public GameObject teleportPoint4;
    public GameObject energyPoint1;
    public GameObject energyPoint2;
    public GameObject energyPoint3;
    public GameObject energyPoint4;
    public GameObject deathPoint1;
    public GameObject deathPoint2;
    public GameObject shield;
    public GameObject energy1;
    public GameObject energy2;
    public GameObject boss;
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
        StartCoroutine("Shake");
        Invoke("EndDialouge", 0.5f);
    }
    void EndDialouge()
    {
        cutscene.endCutscene = true;
        cutscene.textBox.SetActive(true);
        cutscene.ShowText();
    }
    private IEnumerator Shake()
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            // Get random offsets for X and Y
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            // Apply the new position
            transform.localPosition = new Vector3(originalPos.x + x, originalPos.y + y, originalPos.z);

            elapsed += Time.deltaTime;

            // Wait until the next frame
            yield return null;
        }

        // Return to the original position once finished
        transform.localPosition = originalPos;
    }
}
