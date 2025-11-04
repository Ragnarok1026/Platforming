using Unity.Cinemachine;
using UnityEngine;
using System.Collections;

public class BossLife : MonoBehaviour
{
    public int maxHealth = 120;
    public bool isPhase2 = false;
    public bool releaseArrows = false;
    int currentHealth;
    public Animator animator;
    public GameObject attackPointStart;
    public GameObject Arrows;
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;
    public GameObject Arrow4;
    public GameObject Arrow5;
    public GameObject Arrow6;
    public GameObject Arrow7;
    public GameObject Arrow8;
    public GameObject Arrow9;
    public GameObject Arrow10;
    public GameObject Arrow11;
    public GameObject Arrow12;
    public GameObject Arrow13;
    public GameObject Arrow14;
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
        speed = 0;
        StartCoroutine(Phase2());
    }

    IEnumerator Phase2()
    {
        yield return new WaitForSeconds(2f);
        while (isPhase2 == true)
        {
            speed = 4f;
            transform.Translate((attackPointStart.transform.position - transform.position) * speed * Time.deltaTime);
            releaseArrows = true;
            yield return new WaitForSeconds(2f);
            
        }
        yield return new WaitForSeconds(2f);

        while(releaseArrows == true)
        {
            Arrows.SetActive(true);
            yield return new WaitForEndOfFrame();
        }
    }
}
