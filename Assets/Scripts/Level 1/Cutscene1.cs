using System.Collections;
using UnityEngine;

public class Cutscene1 : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public GameObject cutsceneStart;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject boss;
    public float speed = 6f;
    public bool cutsceneActive = false;
    public bool cutscene1 = false;
    public bool cutscene2 = false;
    public bool cutscene3 = false;
    void Update()
    {
        if (player.transform.position.x <= cutsceneStart.transform.position.x && cutsceneActive == false)
        {
            cutsceneActive = true;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
            text1.SetActive(true);
            StartCoroutine(BeginCutscene());
        }
    }

    IEnumerator BeginCutscene()
    {
        while (cutscene1 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("FirstCutscene", 0);
                cutscene1 = true;
            }
            yield return null;
        }
        while (cutscene2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene2 == false)
            {
                Invoke("SecondCutscene", 0);
                cutscene2 = true;
            }
            yield return null;
        }
        while (cutscene3 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene3 == false)
            {
                Invoke("Cutscene3", 0);
                cutscene3 = true;
            }
            yield return null;
        }
        while (boss.transform.position.y < 18.64f)
        {
            boss.transform.Translate(Vector2.up * speed * Time.deltaTime);
            yield return null;
        }
    }
    void FirstCutscene()
    {
        text1.SetActive(false);
        text2.SetActive(true);
    }
    void SecondCutscene()
    {
        text2.SetActive(false);
        text3.SetActive(true);
    }
    void Cutscene3()
    {
        text3.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
