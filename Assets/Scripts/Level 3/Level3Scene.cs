using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Scene : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spear"))
        {
            
        }
    }
}
