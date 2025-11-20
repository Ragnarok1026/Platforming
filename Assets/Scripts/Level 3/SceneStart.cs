using UnityEngine;
using System.Collections;

public class SceneStart : MonoBehaviour
{
    public GameObject Player;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Script;
    public bool text1Done = false;
    public bool text2Done = false;
    public bool text3Done = false;
    public bool text4Done = false;
    void Start()
    {
        Player.GetComponent<PlayerMovement>().enabled = false;
    }
    void Update()
    {
        StartCoroutine(TextSequence());
    }
    IEnumerator TextSequence()
    {
        yield return new WaitForSeconds(2);
        while (text1Done == false)
        {
            if(text1Done == false)
            {
                Invoke("StartText1", 0);
                text1Done = true;
            }
            yield return null;
        }
        while(text2Done == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && text2Done == false)
            {
                Invoke("StartText2", 0);
                text2Done = true;
            }
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        while (text3Done == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && text3Done == false)
            {
                Invoke("StartText3", 0);
                text3Done = true;
            }
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);
        while (text4Done == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && text4Done == false)
            {
                Invoke("StartText4", 0);
                text4Done = true;
            }
            yield return null;
        }
        while (text4Done == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && text4Done == true)
            {
                Invoke("EndCutscene", 1);
            }
            yield return null;
        }
    }
    void StartText1()
    {
        Text1.SetActive(true);
    }
    void StartText2()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
    }
    void StartText3()
    {
        Text2.SetActive(false);
        Text3.SetActive(true);
    }
    void StartText4()
    {
        Text3.SetActive(false);
        Text4.SetActive(true);
    }
    void EndCutscene()
    {
        Script.SetActive(false);
        Text4.SetActive(false);
        Player.GetComponent<PlayerMovement>().enabled = true;
    }
}
