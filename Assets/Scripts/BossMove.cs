using UnityEngine;

public class BossMove : MonoBehaviour
{
    public GameObject leftStop;
    public GameObject rightStop;
    public Animator animator;
    public int speed = 4;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= leftStop.transform.position.x)
        {
            speed = -6;
        }
        else if (transform.position.x >= rightStop.transform.position.x)
        {
            speed = 6;
        }
        if (speed < 0)
        {
            animator.SetFloat("speed", 0);
        }
        else if (speed > 0)
        {
            animator.SetFloat("speed", 1);
        }
    }
}
