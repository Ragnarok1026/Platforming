using UnityEngine;
using System.Collections;

public class CutsceneBoss2 : MonoBehaviour
{
    public GameObject player;
    public GameObject cutsceneStart;
    public Animator animator;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public bool cutsceneActive1 = false;
    public bool cutsceneActive2 = false;
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
            text1.SetActive(true);
        }
    }

    public IEnumerator Cutscene()
    {
        while(cutsceneActive1 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space Pressed");
                Invoke("CutScene1", 0f);
                cutsceneActive1 = true;
            }
            yield return null;
        }
        while(cutsceneActive2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutsceneActive2 == false)
            {
                Invoke("CutScene2", 0f);
                cutsceneActive2 = true;
            }
            yield return null;
        }
        while(cutsceneActive2 == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutsceneActive2 == true)
            {
                Invoke("EndCutscene", 0f);
                cutsceneActive2 = false;
            }
            yield return null;
        }
    }

    void CutScene1()
    {
        text1.SetActive(false);
        text2.SetActive(true);
    }

    void CutScene2()
    {
        text2.SetActive(false);
        text3.SetActive(true);
    }

    void EndCutscene()
    {
        text3.SetActive(false);
        cutsceneStart.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
