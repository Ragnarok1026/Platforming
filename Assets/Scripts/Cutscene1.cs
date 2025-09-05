using UnityEngine;

public class Cutscene1 : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public GameObject cutsceneStart;
    public GameObject Text1;
    public GameObject Text2;
    public bool cutsceneActive = false;
    public bool FightStarted = false;
    void Update()
    {
        if (player.transform.position.x <= cutsceneStart.transform.position.x && cutsceneActive == false)
        {
            cutsceneActive = true;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
            Text1.SetActive(true);
            Invoke("cutScene", 1.5f);
        }
    }
    void cutScene()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
        Invoke("endCutscene", 1.5f);
    }
    void endCutscene()
    {
        Text2.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        Invoke("Fight", 0.5f);
    }

    void Fight()
    {
        FightStarted = true;
        if (FightStarted == true)
        {
            
        }
    }
}
