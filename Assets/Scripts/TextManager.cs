using UnityEngine;

public class TextManager : MonoBehaviour
{
    private float horizontal; 

    public Animator animator;

    public GameObject TextLoader;
    public GameObject Narrator;
    public GameObject Boss;
    public GameObject Player;
    public GameObject Platform;

    bool text1Shown = false;

    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        if(transform.position.x <= TextLoader.transform.position.x && text1Shown == false)
        {
            text1Shown = true;
            Narrator.SetActive(false);
            Boss.SetActive(true);
            Invoke("Text", 1.5f);
            Player.GetComponent<PlayerMovement>().enabled = false;
            Player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            animator.SetFloat("Speed", 0);
        }
    }
    void Text()
    {
        Boss.SetActive(false);
        Platform.SetActive(false);

    }
}
