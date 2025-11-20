using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Scene : MonoBehaviour
{
    public GameObject Screen;
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
            Screen.SetActive(true);
            Invoke("LoadNextScene", 2f);
        }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene("Level 3");
    }
}
