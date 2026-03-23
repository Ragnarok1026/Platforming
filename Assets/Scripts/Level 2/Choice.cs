using UnityEngine;

public class Choice : MonoBehaviour
{
    public GameObject boss;
    public GameObject fightController;
    public Animator animator;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (boss.GetComponent<Boss2Health>().currentHealth == 0 && collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("Dead2");
            Invoke("Death", 0.7f);
        }
    }
    void Death()
    {
        animator.SetTrigger("Dead3");
        Invoke("Death2", 0.7f );
    }
    void Death2()
    {
        animator.SetTrigger("Dead4");
    }
}
