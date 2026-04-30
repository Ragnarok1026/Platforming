using UnityEngine;
using System.Collections;

public class DeathSpeech : MonoBehaviour
{
    public Boss2Health bossHealth;
    public GameObject player;
    public GameObject deathPosition;
    public GameObject speech1;
    public GameObject speech2;
    public GameObject speech3;
    public GameObject speech4;
    public GameObject speech5;
    public GameObject speech6;
    public bool speech1Active = false;
    public bool speech2Active = false;
    public bool speech3Active = false;
    void Start()
    {

    }
    void Update()
    {
        if (bossHealth.currentHealth <= 0 && !speech1Active)
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            transform.position = Vector2.MoveTowards(transform.position, deathPosition.transform.position, 5f * Time.deltaTime);
            speech1.SetActive(true);
            StartCoroutine(Speech());
        }
    }
    IEnumerator Speech()
    {
        while (speech1Active == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("ShowSpeech2", 0f);
                speech1Active = true;
            }
            yield return null;
        }
        while (speech2Active == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("ShowSpeech3", 0f);
                speech2Active = true;
            }
            yield return null;
        }
        while (speech3Active == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("ShowSpeech4", 0f);
                speech3Active = true;
            }
            yield return null;
        }
        yield return null;
    }
    void ShowSpeech2()
    {
        speech1.SetActive(false);
        speech2.SetActive(true);
    }
    void ShowSpeech3()
    {
        speech2.SetActive(false);
        speech3.SetActive(true);
    }
    void ShowSpeech4()
    {
        speech3.SetActive(false);
        speech4.SetActive(true);
    }
}
