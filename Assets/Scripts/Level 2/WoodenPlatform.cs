using UnityEngine;

public class WoodenPlatform : MonoBehaviour
{
    public GameObject boss;
    public GameObject platform;
    public GameObject movePoint;
    public GameObject shield;

    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject attack4;
    public GameObject attack5;
    public GameObject attack6;
    public GameObject attack7;
    public GameObject attack8;
    public GameObject attack9;
    public GameObject attack10;

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

    public float platSpeed;
    public float arrowSpeed;
    void Start()
    {
        
    }
    void Update()
    {
        if(boss.GetComponent<Boss2Health>().phaseThree == true)
        {
            platform.transform.position = Vector2.MoveTowards(platform.transform.position, movePoint.transform.position, platSpeed * Time.deltaTime);
            if (platform.transform.position == movePoint.transform.position)
            {
                attack1.SetActive(true);
                Invoke("Fire1", 1f);
            }
        }
    }
    void Fire1()
    {
        attack1Rb.linearVelocity = new Vector2(0, arrowSpeed);
        Invoke("ShowAttack2", 1f);
    }
    void ShowAttack2()
    {
        attack2.SetActive(true);
        Invoke("Fire2", 1f);
    }
    void Fire2()
    {
        attack2Rb.linearVelocity = new Vector2(0, arrowSpeed);
        Invoke("ShowAttack3", 1f);
    }
    void ShowAttack3()
    {
        attack3.SetActive(true);
        Invoke("Fire3", 1f);
    }
    void Fire3()
    {
        attack3Rb.linearVelocity = new Vector2(-arrowSpeed, 0);
        Invoke("ShowAttack4", 1f);
    }
    void ShowAttack4()
    {
        attack4.SetActive(true);
        Invoke("Fire4", 1f);
    }
    void Fire4()
    {
        attack4Rb.linearVelocity = new Vector2(arrowSpeed, 0);
        Invoke("ShowAttack5", 1f);
    }
    void ShowAttack5()
    {
        attack5.SetActive(true);
        Invoke("Fire5", 1f);
    }
    void Fire5()
    {
        attack5Rb.linearVelocity = new Vector2(0, -arrowSpeed);
        Invoke("ShowAttack6", 1f);
    }
    void ShowAttack6()
    {
        attack6.SetActive(true);
        Invoke("Fire6", 1f);
    }
    void Fire6()
    {
        attack6Rb.linearVelocity = new Vector2(arrowSpeed, 0);
        Invoke("ShowAttack7", 1f);
    }
    void ShowAttack7()
    {
        attack7.SetActive(true);
        Invoke("Fire7", 1f);
    }
    void Fire7()
    {
        attack7Rb.linearVelocity = new Vector2(0, -arrowSpeed);
        Invoke("ShowAttack8", 1f);
    }
    void ShowAttack8()
    {
        attack8.SetActive(true);
        Invoke("Fire8", 1f);
    }
    void Fire8()
    {
        attack8Rb.linearVelocity = new Vector2(0, arrowSpeed);
        Invoke("ShowAttack9", 1f);
    }
    void ShowAttack9()
    {
        attack9.SetActive(true);
        Invoke("Fire9", 1f);
    }
    void Fire9()
    {
        attack9Rb.linearVelocity = new Vector2(-arrowSpeed, 0);
        Invoke("ShowAttack10", 1f);
    }
    void ShowAttack10()
    {
        attack10.SetActive(true);
        Invoke("Fire10", 1f);
    }
    void Fire10()
    {
        attack10Rb.linearVelocity = new Vector2(0, -arrowSpeed);
        Invoke("EndPhaseThree", 2f);
    }
    void EndPhaseThree()
    {
        Destroy(attack1);
        Destroy(attack2);
        Destroy(attack3);
        Destroy(attack4);
        Destroy(attack5);
        Destroy(attack6);
        Destroy(attack7);
        Destroy(attack8);
        Destroy(attack9);
        Destroy(attack10);
        Destroy(platform);
        Invoke("SelfDestruct", 0f);
    }
    void SelfDestruct()
    {
        Destroy(this);
        boss.GetComponent<BossFloat>().enabled = false;
        boss.GetComponent<Rigidbody2D>().gravityScale = 1;
        shield.SetActive(false);
    }
}
