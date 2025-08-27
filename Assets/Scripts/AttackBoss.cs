using UnityEngine;

public class AttackBoss : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask bossLayer;
    public static bool isDead = false;
    public GameObject Player;

    public int attackDamage = 20;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boss" && !isDead)
        {
            foreach (Collider2D Boss in Physics2D.OverlapCircleAll(attackPoint.position, attackRange, bossLayer))
            {
                BossHealth bossHealth = Boss.GetComponent<BossHealth>();
                if (bossHealth != null)
                {
                    bossHealth.TakeDamage(attackDamage);
                }
            }
        }

    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }   
}
