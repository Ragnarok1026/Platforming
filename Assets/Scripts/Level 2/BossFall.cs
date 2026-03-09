using UnityEngine;

public class BossFall : MonoBehaviour
{
    public GameObject boss;
    public GameObject VineShield;
    public GameObject arrow;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Arrow"))
            {
            boss.GetComponent<BossFloat>().enabled = false;
            VineShield.SetActive(false);
            boss.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
