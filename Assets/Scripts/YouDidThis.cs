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
    void Update()
    {
        if (player.transform.position.x >= transform.position.x && cutsceneActive == false)
        {
            cutsceneActive = true;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            text1.SetActive(true);
            if (Input.GetButtonDown("Enter"))
            {
              Dialouge1();
            }
        }
    }

    void Dialouge1()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        if (Input.GetButtonDown("Enter"))
        {
            Dialouge2();

        }
    }

    void Dialouge2()
    {
        text2.SetActive(false);
        text3.SetActive(true);
        if (Input.GetButtonDown("Enter"))
        {
            Dialouge3();

        }
    }

    void Dialouge3()
    {
        text3.SetActive(false);
        text4.SetActive(true);
        if (Input.GetButtonDown("Enter"))
        {
             Reload();

        }
    }

    void Reload()
    {
        SceneManager.LoadScene("Level 2");
    }
}
