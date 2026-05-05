using UnityEngine;

public class ReActivateText : MonoBehaviour
{
    public GameObject textObject;
    public GameObject image;
    private ScrollingText scrollingTextScript;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            image.SetActive(true);
            textObject.GetComponent<ScrollingText>().enabled = true;
            textObject.GetComponent<ScrollingText>().NextText2();
        }
    }
}
