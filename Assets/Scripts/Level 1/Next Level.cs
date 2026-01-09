using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject cutScene;
    public GameObject player;
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
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        Text1.SetActive(true);
        StartCoroutine(NextWorld());
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
            if(Input.GetKeyDown(KeyCode.Space) && cutscene2Started == false)
            {
                Invoke("CutScene2", 0f);
                cutscene2Started = true;
            }
            yield return null;
        }
        while (cutscene2Started == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene2Started == true)
            {
                Invoke("End", 0f);
                yield return null;
            }
        }
    }
    void CutScene1()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    void CutScene2()
    {
        Text2.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
    void End()
    {
        cutScene.SetActive(false);
    }
}
