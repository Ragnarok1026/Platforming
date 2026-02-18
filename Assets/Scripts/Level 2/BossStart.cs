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
    public GameObject startFight;
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
        }
        while (cutsceneActive2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene2", 0f);
                cutsceneActive2 = true;
            }
            yield return null;
        }
        while (cutsceneActive2 == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene3", 0f);
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
    void CutScene3()
    {
        text3.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        Destroy(startFight);
        this.gameObject.SetActive(false);
    }
}
