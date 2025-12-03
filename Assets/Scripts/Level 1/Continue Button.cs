using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ContinueGame1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void ContinueGame2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void ContinueGame3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void ContinueGameBoss1()
    {
        SceneManager.LoadScene("Boss Level 1");
    }
    public void ContinueGameBoss2()
    {
        SceneManager.LoadScene("Boss 2");
    }
    public void ContinueGameBoss3()
    {
        SceneManager.LoadScene("Boss 3");
    }
}
