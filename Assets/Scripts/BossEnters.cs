using System.IO;
using UnityEngine;

public class BossEnters : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Boss;
    public GameObject Trigger;
    public GameObject Player;
    bool text1Shown = false;
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss 1") && text1Shown == false)
        {
            text1Shown = true;
            Text1.SetActive(true);
            Invoke("text1", 1.5f);
        }
    }

    void text1()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
        Boss.SetActive(false);
        Trigger.SetActive(false);
        Invoke("Fight", 1.5f);
    }

    void Fight()
    {
        Text2.SetActive(false);
        Player.GetComponent<PlayerMovement>().enabled = true;
    }
}
