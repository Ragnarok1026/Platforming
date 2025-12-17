using UnityEngine;

public class BossGoUp : MonoBehaviour
{
    public GameObject target;
    public int Speed = 8;
    public bool fightStarted = false;
    void Start()
    {
        fightStarted = false;
    }
    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
        if (transform.position.y >= target.transform.position.y && !fightStarted)
        {
            fightStarted = true;
            Speed = 0;
            GetComponent<BossBattle1>().enabled = true;
            GetComponent<BossGoUp>().enabled = false;
        }
    }
}
