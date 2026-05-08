using UnityEngine;

public class CutsceneEnd : MonoBehaviour
{
    public LevelOneEndText levelOneEndText;
    public GameObject bossTextBox;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                bossTextBox.SetActive(true);
                levelOneEndText.Animate();
                other.gameObject.GetComponent<PlayerMovement>().enabled = false;
                other.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

        }
    }
}
