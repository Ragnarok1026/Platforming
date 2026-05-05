using UnityEngine;
using System.Collections;

public class BossText : MonoBehaviour
{
    public GameObject boss;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public bool cutscene1Started = false;
    public bool cutscene2Started = false;
    void Start()
    {

    }
    void Update()
    {
        if (boss.activeInHierarchy == true && cutscene1Started == false)
        {
            Invoke("StartOpening", 1f);
        }
    }
    void StartOpening()
    {
        text1.SetActive(true);
        StartCoroutine(ShowText());
    }
    void ShowText2()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        
    }
    IEnumerator ShowText()
    {
        while (cutscene1Started == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Invoke("ShowText2", 0);
                cutscene1Started = true;
                yield return null;
            }
            yield return null;
        }
    }

}
