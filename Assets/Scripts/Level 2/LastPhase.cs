using UnityEngine;

public class LastPhase : MonoBehaviour
{
    public GameObject boss;
    public GameObject shield;

    public GameObject ragePoint;
    public GameObject charge1Point;
    public GameObject charge2Point;
    public GameObject finalStandingPoint;
    public GameObject slamPoint;

    public GameObject debuffArrows;
    public GameObject attackOne;
    public GameObject attackTwo;
    public GameObject attackThree;
    public GameObject attackFour;
    public GameObject attackFive;
    public GameObject attackSix;
    public GameObject attackSeven;
    public GameObject attackEight;
    public GameObject attackNine;
    public GameObject attackTen;
    public GameObject attackEleven;
    public GameObject attackTwelve;

    public float rotationSpeed;
    public float speed;
    public float bossSpeed;

    public Rigidbody2D debuffRb;
    public Rigidbody2D bossRb;
    public Rigidbody2D attack1Rb;
    public Rigidbody2D attack2Rb;
    public Rigidbody2D attack3Rb;
    public Rigidbody2D attack4Rb;
    public Rigidbody2D attack5Rb;
    public Rigidbody2D attack6Rb;
    public Rigidbody2D attack7Rb;
    public Rigidbody2D attack8Rb;
    public Rigidbody2D attack9Rb;
    public Rigidbody2D attack10Rb;
    public Rigidbody2D attack11Rb;
    public Rigidbody2D attack12Rb;
    void Start()
    {

    }
    void Update()
    {
        if (boss.GetComponent<Boss2Health>().finalPhase == true)
        {
            Invoke("FinalPhase", 0.5f);
        }
        if (boss.transform.position == ragePoint.transform.position)
        {
            Invoke("RapidFire", 0.5f);
        }
        if (boss.transform.position == finalStandingPoint.transform.position)
        {
            Invoke("ShowDownArrow1", 0.5f);
        }
        if (boss.transform.position == slamPoint.transform.position)
        {
            shield.SetActive(false);
        }
    }
    void FinalPhase()
    {
        boss.GetComponent<Rigidbody2D>().gravityScale = 0;
        boss.GetComponent<BossFloat>().enabled = true;
        Invoke("Rage", 2f);
    }
    void Rage()
    {
        boss.GetComponent<BossFloat>().enabled = false;
        boss.GetComponent<Rigidbody2D>().gravityScale = 0;
        boss.transform.position = Vector2.MoveTowards(boss.transform.position, ragePoint.transform.position, bossSpeed * Time.deltaTime);
        shield.transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        Invoke("Terminate", 1f);
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
        Invoke("Charge1", 1.5f);
    }
    void Charge1()
    {
        ragePoint = charge1Point;
        bossSpeed = 20f;
        Invoke("ShowAttack4", 1.5f);
    }
    void ShowAttack4()
    {
        attackFour.SetActive(true);
        Invoke("Attack4", 0.3f);
    }
    void Attack4()
    {
        attack4Rb.linearVelocity = new Vector2(speed, 0);
        Invoke("ShowAttack5", 0.3f);
    }
    void ShowAttack5()
    {
        attackFive.SetActive(true);
        Invoke("Attack5", 0.3f);
    }
    void Attack5()
    {
        attack5Rb.linearVelocity = new Vector2(speed, 0);
        Invoke("ShowAttack6", 0.3f);
    }
    void ShowAttack6()
    {
        attackSix.SetActive(true);
        Invoke("Attack6", 0.3f);
    }
    void Attack6()
    {
        attack6Rb.linearVelocity = new Vector2(speed, 0);
        Invoke("Charge2", 1.5f);
    }
    void Charge2()
    {
        charge1Point = charge2Point;
        bossSpeed = 20f;
        Invoke("FinalAttack", 1.5f);
    }
    void FinalAttack()
    {
        bossSpeed = 50f;
        charge2Point = finalStandingPoint;
    }
    void ShowDownArrow1()
    {
        attackSeven.SetActive(true);
        attackEight.SetActive(true);
        attackNine.SetActive(true);
        attackTen.SetActive(true);
        Invoke("DownArrow1", 0.5f);
    }
    void DownArrow1()
    {
        attack7Rb.linearVelocity = new Vector2(0, -speed);
        Invoke("DownArrow2", 0.3f);
    }
    void DownArrow2()
    {
        attack8Rb.linearVelocity = new Vector2(0, -speed);
        Invoke("DownArrow3", 0.3f);
    }
    void DownArrow3()
    {
        attack9Rb.linearVelocity = new Vector2(0, -speed);
        Invoke("DownArrow4", 0.3f);
    }
    void DownArrow4()
    {
        attack10Rb.linearVelocity = new Vector2(0, -speed);
        Invoke("BossSlam", 1f);
    }
    void BossSlam()
    {
        finalStandingPoint = slamPoint;
        bossSpeed = 20f;
        Invoke("AfterShock", 0.6f);
    }
    void AfterShock()
    {
        attackEleven.SetActive(true);
        attackTwelve.SetActive(true);
        Invoke("Release", 0.6f);
    }

    void Release()
    {
        attack11Rb.linearVelocity = new Vector2(-speed, 0);
        attack12Rb.linearVelocity = new Vector2(speed, 0);
        Invoke("EndFight", 0.5f);
    }
    void EndFight()
    {
        Destroy(attackOne);
        Destroy(attackTwo);
        Destroy(attackThree);
        Destroy(attackFour);
        Destroy(attackFive);
        Destroy(attackSix);
        Destroy(attackSeven);
        Destroy(attackEight);
        Destroy(attackNine);
        Destroy(attackTen);
        Destroy(attackEleven);
        Destroy(attackTwelve);
        Destroy(this);
    }
}
