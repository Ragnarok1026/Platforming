using UnityEngine;

public class CutsceneEnd : MonoBehaviour
{
    public LevelOneEndText levelOneEndText;
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
                other.gameObject.GetComponent<PlayerMovement>().enabled = false;
                other.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
                levelOneEndText.textBox.SetActive(true);

        }
    }
}
