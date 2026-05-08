using System.Collections;
using UnityEngine;

public class Cutscene1 : MonoBehaviour
{
    public GameObject player;
    public GameObject trigger;
    public GameObject bossCam;
    public BossText bossText;
    public GameObject bossTextBox;
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bossTextBox.SetActive(true);
            bossText.Animate();
            player.GetComponent<AudioSource>().Pause();
            bossCam.GetComponent<AudioSource>().Play();
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            trigger.SetActive(false);
        }
    }
}
