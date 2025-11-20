using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ShadowCutscene : MonoBehaviour
{
    public GameObject Player;
    public GameObject Entity;
    public GameObject Shadow;
    public GameObject shadowScene1;
    public GameObject shadowScene2;
    public GameObject shadowScene3;
    public GameObject KillTrigger;
    public bool cutscene1 = false;
    public bool cutscene2 = false;
    public bool cutscene3 = false;
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
            shadowScene1.SetActive(true);
            StartCoroutine(ShadowScene());
        }
    }
    IEnumerator ShadowScene()
    {
        while (cutscene1 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("Cutscene1", 0);
                cutscene1 = true;
            }
            yield return null;
        }
        while (cutscene2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene2 == false)
            {
                Invoke("Cutscene2", 0);
                cutscene2 = true;
            }
            yield return null;
        }
        while (cutscene3 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene3 == false)
            {
                Invoke("Cutscene3", 0);
                cutscene3 = true;
            }
            yield return null;
        }
    }

    void Cutscene1()
    {
        shadowScene1.SetActive(false);
        shadowScene2.SetActive(true);
    }
    void Cutscene2()
    {
        shadowScene2.SetActive(false);
        shadowScene3.SetActive(true);
    }
    void Cutscene3()
    {
        shadowScene3.SetActive(false);
        Invoke("StartCombat", 0);
    }
    void StartCombat()
    {
        Destroy(KillTrigger);
        Shadow.GetComponent<FightStart>().enabled = true;
    }
}
