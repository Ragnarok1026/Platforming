using UnityEngine;

public class BossStomp : MonoBehaviour
{
    public int Speed = 0;
    public GameObject Stop;
    public GameObject target;
    public bool fightStarted = false;
    void Start()
    {
        Speed = 8;
    }
    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
        Speed = 15;
        if(transform.position.y <= Stop.transform.position.y)
        {
            Speed = 0;
            Invoke("BackUp", 2f);
        }
    }
    void BackUp()
    {
        GetComponent<BossGoUp>().enabled = true;
        GetComponent<BossStomp>().enabled = false;
    }
}
