using UnityEngine;

public class FernyText : MonoBehaviour
{
    public GameObject Box;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public Animator animator;
    public GameObject cutsceneStart;
    public bool cutsceneActive = false;
    void Update()
    {
        if (transform.position.x >= cutsceneStart.transform.position.x && cutsceneActive == false)
        {
            cutsceneActive = true;
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
            Box.SetActive(true);
            text1.SetActive(true);
            Invoke("CutScene1", 4f);
        }
    }

    void CutScene1()
    {
        GetComponent<PlayerMovement>().enabled = false;
        text1.SetActive(false);
        text2.SetActive(true);
        Invoke("CutScene2", 6f);
    }

    void CutScene2()
    {
        text2.SetActive(false);
        text3.SetActive(true);
        Invoke("EndCutscene", 2f);

    }
    void EndCutscene()
    {
        Box.SetActive(false);
        text3.SetActive(false);
        GetComponent<PlayerMovement>().enabled = true;

    }
}
