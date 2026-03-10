using UnityEngine;

public class ArmiesRise : MonoBehaviour
{
    public float speed = 10f;
    public GameObject floatPoint;
    public GameObject boss;

    public GameObject Attack1;
    public GameObject Attack2;
    public GameObject Attack3;
    public GameObject Attack4;

    private Rigidbody2D attack1Rb;
    private Rigidbody2D attack2Rb;
    private Rigidbody2D attack3Rb;
    private Rigidbody2D attack4Rb;


    void Start()
    {
        if (Attack1 != null)
        {
            attack1Rb = Attack1.GetComponent<Rigidbody2D>();
            attack2Rb = Attack2.GetComponent<Rigidbody2D>();
            attack3Rb = Attack3.GetComponent<Rigidbody2D>(); 
            attack4Rb = Attack4.GetComponent<Rigidbody2D>();

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
            Attack1.SetActive(false);
        }
        Invoke("ShowAttackThree", 1f);
    }
    void ShowAttackThree()
    {
        Attack3.SetActive(true);
        Attack4.SetActive(true);
        Invoke("AttackThree", 1f);
    }
    void AttackThree()
    {
        if (attack3Rb != null)
        {
            attack3Rb.linearVelocity = new Vector2(-speed, 0);
            Attack2.SetActive(false);
            Invoke("AttackFour", 0.6f);
        }
    }
    void AttackFour()
    {
        if (attack4Rb != null)
        {
            attack4Rb.linearVelocity = new Vector2(speed, 0);
            Invoke("DisableAttacks", 3f);
        }
    }
    void DisableAttacks()
    {
        Destroy(Attack1);
        Destroy(Attack2);
        Destroy(Attack3);
        Destroy(Attack4);
        Destroy(this);
    }
}
