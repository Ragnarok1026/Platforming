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
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
        animator.SetFloat("Speed", 0);
        Text1.SetActive(true);
        StartCoroutine(Cutscene());
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
            yield return new WaitForEndOfFrame();
        }
        while (cutsceneActive2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutsceneActive2 == false)
            {
                Invoke("CutScene2", 0f);
                cutsceneActive2 = true;
            }
            yield return new WaitForEndOfFrame();
        }
        while (cutsceneActive3 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutsceneActive3 == false)
            {
                Invoke("CutScene3", 0f);
                cutsceneActive3 = true;
            }
            yield return new WaitForEndOfFrame();
        }
        while (cutsceneActive3 == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutsceneActive3 == true)
            {
                Invoke("EndCutscene", 0f);
                cutsceneActive2 = false;
            }
            yield return new WaitForEndOfFrame();
        }
    }
    void CutScene1()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
        cutsceneActive1 = false;
    }
    void CutScene2()
    {
        Text2.SetActive(false);
        Text3.SetActive(true);
        cutsceneActive2 = false;
    }
    void CutScene3()
    {
        Text3.SetActive(false);
        Text4.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
    void EndCutscene()
    {
        Text4.SetActive(false);
        Destroy(cutsceneStart);
    }
}
