using UnityEngine;
using System.Collections;

public class ShadowHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Animator animator;
    public float bounce;
    public bool cutsceneActive1 = false;
    public bool cutsceneActive2 = false;
    public bool cutsceneActive3 = false;
    public Rigidbody2D rb;
    public GameObject Shadow;
    public GameObject Player;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public PlayerMovement playerMovementScript;
    void Start()
    {
        currentHealth = maxHealth;
        playerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Text1.SetActive(true);
        Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        StartCoroutine(Death());
    }

    IEnumerator Death()
    {
        while (cutsceneActive1 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene1", 0f);
                cutsceneActive1 = true;
            }
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        while (cutsceneActive2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene2", 0f);
                cutsceneActive2 = true;
            }
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        while (cutsceneActive3 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene3", 0f);
                cutsceneActive3 = true;
            }
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
        while (cutsceneActive3 == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("EndCutscene", 0f);
                cutsceneActive3 = false;
            }
            yield return null;
        }
    }
    void CutScene1()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    void CutScene2()
    {
        Text2.SetActive(false);
        Text3.SetActive(true);
    }
    void CutScene3()
    {
        Text3.SetActive(false);
        Text4.SetActive(true);
    }
    void EndCutscene()
    {
        Text4.SetActive(false);
    }
}
