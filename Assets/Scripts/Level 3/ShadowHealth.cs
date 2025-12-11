using UnityEngine;
using System.Collections;

public class ShadowHealth : MonoBehaviour
{
    private StartShadow startShadowScript;
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
    public GameObject player;
    public GameObject particle;
    void Start()
    {
        currentHealth = maxHealth;
        startShadowScript = GameObject.Find("HoverPoint").GetComponent<StartShadow>();
    }
    void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            animator.SetTrigger("Hurt");
            animator.SetBool("isDead", true);
            startShadowScript.enabled = true;
            
            Die();
        }
    }
    void Die()
    {
        Text1.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        Shadow.GetComponent<BoxCollider2D>().enabled = false;
        Shadow.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        Shadow.GetComponent<Rigidbody2D>().gravityScale = -1;
        StartCoroutine(Death());
    }

    IEnumerator Death()
    {
        particle.SetActive(true);
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
        particle.SetActive(false);
    }
}
