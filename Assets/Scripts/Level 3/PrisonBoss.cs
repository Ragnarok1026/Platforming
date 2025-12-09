using System.Collections;
using UnityEngine;


public class PrisonBoss : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject cutsceneStart;
    public bool cutsceneActive1 = false;
    public bool cutsceneActive2 = false;
    public bool cutsceneActive3 = false;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
            Text1.SetActive(true);
            StartCoroutine(Cutscene());   
        }
    }
    IEnumerator Cutscene()
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
        Destroy(cutsceneStart);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
