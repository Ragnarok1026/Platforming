using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTree : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Boss 2");
        }
    }
}
