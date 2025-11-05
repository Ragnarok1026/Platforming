using Unity.Cinemachine;
using UnityEngine;
using System.Collections;

public class BossLife : MonoBehaviour
{
    public int maxHealth = 120;
    public bool isPhase2 = false;
    public bool releaseArrows = false;
    public bool phase2Started = false;
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
    public GameObject Arrow15;
    public GameObject Arrow16;
    public GameObject Arrow17;
    public GameObject Arrow18;

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
        isPhase2 = true;
        GetComponent<BossFight2>().enabled = false;
        Debug.Log("Boss Angered");
        StartCoroutine(ReleaseArrows());
    }

    IEnumerator ReleaseArrows()
    {
        GetComponent<BossFight2>().attackPhase1 = false;
        yield return new WaitForSeconds(5f);
        releaseArrows = true;

        while(releaseArrows == true)
        {
            Arrows.SetActive(true);
            phase2Started = true;
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(2f);

        while(phase2Started == true)
        {
            Debug.Log("Releasing Arrows");
            Arrow1.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            yield return new WaitForEndOfFrame();
        }
    }
}
