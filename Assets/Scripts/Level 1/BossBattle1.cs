using UnityEngine;
using System.Collections;

public class BossBattle1 : MonoBehaviour
{
    public GameObject boss;
    public GameObject player;
    public GameObject patrolRight;
    public GameObject patrolLeft;
    public int Speed = 8;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
        Invoke("BossMove", 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Speed = 0;
            Invoke("BossStompAttack", 1f);
            Invoke("BossStomp", 1f);
        }
    }
    void BossMove()
    {
        if (transform.position.x <= patrolLeft.transform.position.x)
        {
            Speed = -8;
        }
        else if (transform.position.x >= patrolRight.transform.position.x)
        {
            Speed = 8;
        }
    }
    void BossStompAttack()
    {
        boss.GetComponent<BossStomp>().enabled = true;
        GetComponent<BossBattle1>().enabled = false;
    }
    void BossStomp()
    {
        Speed = 8;
    }
}
