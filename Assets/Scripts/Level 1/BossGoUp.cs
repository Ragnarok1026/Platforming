using UnityEngine;

public class BossGoUp : MonoBehaviour
{
    public GameObject boss;
    public GameObject target;
    public int Speed = 8;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
        if (transform.position.y >= target.transform.position.y)
        {
            boss.GetComponent<BossBattle1>().enabled = true;
            boss.GetComponent<BossGoUp>().enabled = false;
        }
    }
}
