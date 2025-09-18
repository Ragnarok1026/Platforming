using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDidThis : MonoBehaviour
{
    public bool cutsceneActive = false;
    public GameObject player;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    void Update()
    {
        if (player.transform.position.x >= transform.position.x && cutsceneActive == false)
        {
            cutsceneActive = true;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            text1.SetActive(true);
            Invoke("ThisIsYourFault", 3f);
        }
    }

    void ThisIsYourFault()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        enemy1.SetActive(false);
        enemy2.SetActive(true);
        Invoke("WhatYouDeserve", 3f);
    }

    void WhatYouDeserve()
    {
        text2.SetActive(false);
        text3.SetActive(true);
        enemy2.SetActive(false);
        enemy3.SetActive(true);
        Invoke("Begone", 3f);
    }

    void Begone()
    {
        text3.SetActive(false);
        text4.SetActive(true);
        enemy3.SetActive(false);
        enemy4.SetActive(true);
        Invoke("Reload", 2f);
    }

    void Reload()
    {
        SceneManager.LoadScene("Level 2");
    }
}
