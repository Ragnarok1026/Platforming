using System.Collections;
using UnityEngine;

public class Cutscene1 : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public GameObject cutsceneStart;
    public GameObject text1;
    public GameObject text2;
    public bool cutsceneActive = false;
    public float speed = 6f;
    public GameObject boss;
    void Update()
    {
        if (player.transform.position.x <= cutsceneStart.transform.position.x && cutsceneActive == false)
        {
            cutsceneActive = true;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
            text1.SetActive(true);
            Invoke("CutScene", 1.5f);
        }
    }
    void CutScene()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        Invoke("EndCutscene", 1.5f);
    }
    void EndCutscene()
    {
        text2.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        StartCoroutine(Fight());
    }

    IEnumerator Fight()
    {
        while (boss.transform.position.y < 18.64f)
        {
        boss.transform.Translate(Vector2.up * speed * Time.deltaTime);
            yield return null;

        }

    }
}
