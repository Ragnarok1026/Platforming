using UnityEngine;
using System.Collections;

public class BossStart : MonoBehaviour
{
    public bool cutsceneActive1 = false;
    public bool cutsceneActive2 = false;
    bool bossTrigger = false;
    public GameObject player;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bossTrigger = true;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            text1.SetActive(true);
            StartCoroutine(BossText());
        }
    }
    IEnumerator BossText()
    {
        while (cutsceneActive1 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene1", 0f);
                cutsceneActive1 = true;
            }
            yield return null;
            while (cutsceneActive1 == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Invoke("CutScene1", 0f);
                    cutsceneActive1 = true;
                }
                yield return null;
                yield return null;
            }
        }
        void CutScene1()
        {
            text1.SetActive(false);
            text2.SetActive(true);
        }
    }
}
