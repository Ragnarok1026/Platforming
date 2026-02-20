using UnityEngine;

public class ArmiesRise : MonoBehaviour
{
    public GameObject floatPoint;
    public GameObject boss;
    public GameObject Attack1;
    public GameObject Attack2;
    public float speed = 10f;

    private Rigidbody2D attack1Rb;
    private Rigidbody2D attack2Rb;

    void Start()
    {
        if (Attack1 != null)
        {
            attack1Rb = Attack1.GetComponent<Rigidbody2D>();
            attack2Rb = Attack2.GetComponent<Rigidbody2D>();
        }
    }

    void Update()
    {
        if (boss.transform.position == floatPoint.transform.position)
        {
            Attack1.SetActive(true);
            Invoke("AttackOne", 1f);
        }
    }

    void AttackOne()
    {
        if (attack1Rb != null)
        {
            attack1Rb.linearVelocity = new Vector2(-speed, 0);
        }
        Invoke("ShowAttackTwo", 1f);
    }
    void ShowAttackTwo()
    {
        Attack2.SetActive(true);
        Invoke("AttackTwo", 1f);
    }
        void AttackTwo()
    {
        if (attack2Rb != null)
        {
            attack2Rb.linearVelocity = new Vector2(-speed, 0);
        }
    }
}
