using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Charge : MonoBehaviour
{
    public GameObject boss;
    public GameObject ragePoint;
    public GameObject debuffArrows;
    public GameObject attackOne;
    public GameObject attackTwo;
    public GameObject attackThree;

    public float speed;

    public Rigidbody2D debuffRb;
    public Rigidbody2D bossRb;
    public Rigidbody2D attack1Rb;
    public Rigidbody2D attack2Rb;
    public Rigidbody2D attack3Rb;

    void Start()
    {
        
    }
    void Update()
    {
        if (boss.transform.position == ragePoint.transform.position)
        {
            Invoke("RapidFire", 0.5f);
        }
    }
    void RapidFire()
    {
        debuffArrows.SetActive(true);
        Invoke("FireDebuff", 0.5f);
    }
    void FireDebuff()
    {
        debuffRb.linearVelocity = new Vector2(-speed, 0);
        Invoke("ShowAttack1", 0.5f);
    }
    void ShowAttack1()
    {
        attackOne.SetActive(true);
        Invoke("Attack1", 0.7f);
    }
    void Attack1()
    {
        attack1Rb.linearVelocity = new Vector2(-speed, 0);
        Invoke("ShowAttack2", 0.4f);
    }
    void ShowAttack2()
    {
        attackTwo.SetActive(true);
        Invoke("Attack2", 0.3f);
    }
    void Attack2()
    {
        attack2Rb.linearVelocity = new Vector2(-speed, 0);
        Invoke("ShowAttack3", 0.3f);
    }
    void ShowAttack3()
    {
        attackThree.SetActive(true);
        Invoke("Attack3", 0.3f);
    }
    void Attack3()
    {
        attack3Rb.linearVelocity = new Vector2(-speed, 0);
        Invoke("Charge1", 0.3f);
    }
    void Charge1()
    {
        bossRb.linearVelocity = new Vector2(-speed, 0);
    }
}
