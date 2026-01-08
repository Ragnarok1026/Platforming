using UnityEngine;

public class BossStomp : MonoBehaviour
{
    public int Speed = 0;
    public GameObject Stop;
    public GameObject target;
    public bool fightStarted = false;
    void Start()
    {
        // Initial speed set to 8
        Speed = 8;
    }
    void Update()
    {
        // Boss moves downwards during stomp attack
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
        // Stops movement upon reaching the Stop position
        Speed = 15;
        // Check if boss has reached or passed the Stop position
        if (transform.position.y <= Stop.transform.position.y)
        {
            Speed = 0;
            Invoke("BackUp", 2f);
        }
    }
    void BackUp()
    {
        // Switches to BossGoUp behavior after stomp
        GetComponent<BossGoUp>().enabled = true;
        GetComponent<BossStomp>().enabled = false;
    }
}
