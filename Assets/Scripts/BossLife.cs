using Unity.Cinemachine;
using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class BossLife : MonoBehaviour
{
    public ResetArrows resetArrowsScript;
    public int maxHealth = 120;
    public bool isPhase2 = false;
    public bool releaseArrows = false;
    public bool resetArrows = false;
    int currentHealth;
    public Animator animator;
    public GameObject attackPointStart;
    public GameObject barrier;
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
        animator.SetBool("Defeated", false);
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
        BossFight2 bossFight = GetComponent<BossFight2>();
        bossFight.enabled = false;
        bossFight.attackPhase1 = false;
        bossFight.StopAllCoroutines();
        releaseArrows = true;
        StartCoroutine(ShowArrows());
    }
    IEnumerator ShowArrows()
    {
        yield return new WaitForSeconds(1f);
        while (Vector2.Distance(transform.position, attackPointStart.transform.position) > 1f)
        {
            speed = 2f;
            transform.Translate((attackPointStart.transform.position - transform.position) * speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(0.5f);
        if (releaseArrows == true && transform.position.y >= barrier.transform.position.y)
        {
            Arrows.SetActive(true);
        }
        yield return new WaitForSeconds(0.3f);
        Arrow1.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow2.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow3.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow4.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow5.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow6.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow7.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow8.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow9.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow10.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow11.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow12.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow13.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow14.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow15.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow16.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow17.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        yield return new WaitForSeconds(0.3f);
        Arrow18.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        Debug.Log("All arrows released");
        releaseArrows = false;
        yield return new WaitForSeconds(2f);
        Arrows.SetActive(false);
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(1f);
        animator.SetBool("Defeated", true);
    }
}
