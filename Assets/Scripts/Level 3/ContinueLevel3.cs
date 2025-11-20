using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueLevel3 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Continue()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
