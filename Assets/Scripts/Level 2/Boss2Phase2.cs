using UnityEngine;

public class Boss2Phase2 : MonoBehaviour
{
    public GameObject boss;
    public GameObject trigger;
    public GameObject floatPoint;
    public GameObject shield;
    public float speed = 15f;

    public GameObject Part1;
    public GameObject Part2;
    public GameObject Part3;
    public GameObject Part4;
    public GameObject Part5;
    public GameObject Part6;

    public Rigidbody2D part1Rb;
    public Rigidbody2D part2Rb;
    public Rigidbody2D part3Rb;
    public Rigidbody2D part4Rb;
    public Rigidbody2D part5Rb;
    public Rigidbody2D part6Rb;
    void Start()
    {
        part1Rb = Part1.GetComponent<Rigidbody2D>();
        part2Rb = Part2.GetComponent<Rigidbody2D>();
        part3Rb = Part3.GetComponent<Rigidbody2D>();
        part4Rb = Part4.GetComponent<Rigidbody2D>();
        part5Rb = Part5.GetComponent<Rigidbody2D>();
        part6Rb = Part6.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (boss.GetComponent<Boss2Health>().phaseTwo == true)
        {
            if (boss.transform.position == floatPoint.transform.position)
            {
                 Part1.SetActive(true);
                 Invoke("Fire1", 1f);
            }
            
        }
    }
    void Fire1()
    {
        part1Rb.linearVelocity = new Vector2(0, -speed);
        Invoke("ShowPart2", 0.4f);
    }
    void ShowPart2()
    {
        Part2.SetActive(true);
        Invoke("Fire2", 1f);
    }
    void Fire2()
    {
        part2Rb.linearVelocity = new Vector2(0, -speed);
        Invoke("ShowPart3", 0.4f);
    }
    void ShowPart3()
    {
        Part3.SetActive(true);
        Invoke("Fire3", 1.4f);
    }
    void Fire3()
    {
        part3Rb.linearVelocity = new Vector2(0, -speed);
        Invoke("ShowPart4", 0.4f);
    }
    void ShowPart4()
    {
        Part4.SetActive(true);
        Invoke("Fire4", 1f);
    }
    void Fire4()
    {
        part4Rb.linearVelocity = new Vector2(-speed, 0);
        Invoke("ShowPart5", 0.4f);
    }
    void ShowPart5()
    {
        Part5.SetActive(true);
        Invoke("Fire5", 0.4f);
    }
    void Fire5()
    {
        part5Rb.linearVelocity = new Vector2(-speed, 0);
        Invoke("ShowPart6", 0.4f);
    }
    void ShowPart6()
    {
        Part6.SetActive(true);
        Invoke("Fire6", 0.4f);
    }
    void Fire6()
    {
        part6Rb.linearVelocity = new Vector2(-speed, 0);
        Invoke("FallBack", 0.4f);
    }
    void FallBack()
    {
        boss.GetComponent<BossFloat>().enabled = false;
        boss.GetComponent<Rigidbody2D>().gravityScale = 1;
        Destroy(trigger);
        shield.SetActive(false);
        Invoke("ResetBoss", 2f);
    }
    void ResetBoss()
    {
        Destroy(Part1);
        Destroy(Part2);
        Destroy(Part3);
        Destroy(Part4);
        Destroy(Part5);
        Destroy(Part6);
        Destroy(this);
    }
}
