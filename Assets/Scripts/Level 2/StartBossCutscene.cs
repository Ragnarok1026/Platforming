using UnityEngine;

public class StartBossCutscene : MonoBehaviour
{
    public GameObject player;
    public GameObject boss;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            Invoke("BossAppears", 1.5f);
        }
    }
    void BossAppears()
    {
        boss.SetActive(true);
    }
}