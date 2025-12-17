using UnityEngine;
using System.Collections;

public class StartCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject Boss;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public Animator animator;
    public bool cutscene1Started = false;
    public bool cutscene2Started = false;
    public bool cutscene3Started = false;
    void Start()
    {

    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.GetComponent<PlayerMovement>().enabled = false;
            Player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            animator.SetFloat("Speed", 0f);
            Text1.SetActive(true);
            StartCoroutine(Cutscene1());
        }
    }
    IEnumerator Cutscene1()
    {
        while(cutscene1Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene1", 0f);
                cutscene1Started = true;
            }
            yield return null;
        }
        while(cutscene2Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene2Started == false)
            {
                Invoke("CutScene2", 0f);
                cutscene2Started = true;
            }
            yield return null;
        }
        while(cutscene3Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene3Started == false)
            {
                Invoke("CutScene3", 0f);
                cutscene3Started = true;
            }
            yield return null;
        }
        while(cutscene3Started == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene3Started == true)
            {
                Invoke("EndCutscene", 0f);
                cutscene3Started = false;
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
        Player.GetComponent<PlayerMovement>().enabled = true;
        Boss.GetComponent<BossGoUp>().enabled = true;
        Destroy(this.gameObject);
    }
}
