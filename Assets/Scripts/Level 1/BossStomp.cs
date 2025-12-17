using UnityEngine;

public class BossStomp : MonoBehaviour
{
    public int Speed = 0;
    public GameObject Stop;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
        Speed = 15;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Stop)
        {
            Speed = 0;
            Invoke("BossGoUp", 1f);
        }
    }
    void BossGoUp()
    {
        GetComponent<BossGoUp>().enabled = true;
        GetComponent<BossStomp>().enabled = false;
    }
}
