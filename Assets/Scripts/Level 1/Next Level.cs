using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject cutScene;
    public GameObject nextLevel;
    public GameObject Text1;
    public GameObject Text2;
    public bool cutscene1Started = false;
    public bool cutscene2Started = false;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cutscene"))
        {
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            Text1.SetActive(true);
            StartCoroutine(NextWorld());
        }
        if (other.CompareTag("NextLevel"))
        {
            SceneManager.LoadScene("Overworld");
        }
    }
    IEnumerator NextWorld()
    {
        while (cutscene1Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("CutScene1", 0f);
                cutscene1Started = true;
            }
            yield return null;
        }
        while (cutscene2Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene2Started == false)
            {
                Invoke("End", 0f);
                cutscene2Started = true;
            }
            yield return null;
        }
    }
    void CutScene1()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    void End()
    {
        Text2.SetActive(false);
        GetComponent<PlayerMovement>().enabled = true;
    }
}
