using UnityEngine;
using System.Collections;

public class ShadowCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject Entity;
    public GameObject Shadow;
    public GameObject shadowScene1;
    public GameObject shadowScene2;
    public GameObject shadowScene3;
    public bool Scene1 = false;
    public bool Scene2 = false;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == Entity)
        {
            Debug.Log("Hit");
            shadowScene1.SetActive(true);
            StartCoroutine(ShadowScene());
        }
    }
    IEnumerator ShadowScene()
    {
        while(Scene1 == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Invoke("Cutscene1", 0);
                Scene1 = true;
            }
            yield return null;
        }
        while(Scene2 == false)
        {
            if (Input.GetKey(KeyCode.Space) && Scene2 == false)
            {
                Invoke("Cutscene2", 0);
                Scene2 = true;
            }
            yield return null;
        }
        yield return null;
    }
    void Cutscene1()
    {
        Debug.Log("Hit");
        shadowScene1.SetActive(false);
        shadowScene2.SetActive(true);
    }
    void Cutscene2()
    {
        shadowScene2.SetActive(false);
        shadowScene3.SetActive(true);
    }
}
