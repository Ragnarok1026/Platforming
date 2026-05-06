using UnityEngine;

public class ReActivateText : MonoBehaviour
{
    public GameObject textBox;
    public ScrollingText scrollingText;
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
           textBox.SetActive(true);
           scrollingText.NextText2();
        }
    }
}
