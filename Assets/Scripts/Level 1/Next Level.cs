using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public GameObject Text1;
    public GameObject Text2;
    public bool CutsceneActive1 = false;
    public bool CutsceneActive2 = false;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            animator.SetFloat("Speed", 0f);
            Text1.SetActive(true);
            StartCoroutine(Level2());
        }
    }

    IEnumerator Level2()
    {
        while (CutsceneActive1 == false)
        {
            if(Input.GetKeyDown(KeyCode.Space) && CutsceneActive1 == false)
            {
                Text1.SetActive(false);
                Text2.SetActive(true);
                CutsceneActive1 = true;
            }
            yield return null;
        }
        yield return null;
    }
}
