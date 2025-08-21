using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
   public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("Hurt", true);

        }
    }
}
