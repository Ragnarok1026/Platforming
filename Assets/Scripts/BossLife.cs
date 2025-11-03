using Unity.Cinemachine;
using UnityEngine;
using System.Collections;

public class BossLife : MonoBehaviour
{
    public int maxHealth = 120;
    public bool isPhase2 = false;
    int currentHealth;
    public Animator animator;
    public GameObject attackPointStart;
    public GameObject NextPhase;
    public float speed = 3f;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            StartPhase2();
        }
    }

    void StartPhase2()
    {
        GetComponent<BossFight2>().enabled = false;
        Debug.Log("Boss Angered");
        isPhase2 = true;
        StartCoroutine(Phase2());
    }

    IEnumerator Phase2()
    {
        while (isPhase2 == true)
        {
            speed = 4f;
            transform.Translate((attackPointStart.transform.position - transform.position) * speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(1f);
    }
}
