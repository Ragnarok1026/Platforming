using UnityEngine;
using System.Collections;

public class BossBattle1 : MonoBehaviour
{
    public GameObject cutscene;
    public GameObject Boss;
    public GameObject Target;
    public GameObject Wave1;
    public GameObject Wave2;
    public GameObject Wave3;
    public GameObject Wave4;
    public GameObject Wave5;
    public bool fightStarted = false;
    void Start()
    {
        
    }
    void Update()
    {
        if(fightStarted == false)
        {
            Boss.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Target)
        {
            Boss.GetComponent<Rigidbody2D>().gravityScale = 5;
            Invoke("StartFight", 1f);
        }
    }
    void StartFight()
    {
        Boss.GetComponent<Rigidbody2D>().gravityScale = -1;
        Boss.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        fightStarted = true;
        StartCoroutine(FightStart());
    }
    IEnumerator FightStart()
    {
        Wave1.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        Wave1.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -20);
        yield return new WaitForSeconds(0.1f);

        Wave2.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        Wave2.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -20);
        yield return new WaitForSeconds(0.1f);

        Wave3.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        Wave3.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -20);
        yield return new WaitForSeconds(0.1f);

        Wave4.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        Wave4.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -20);
        yield return new WaitForSeconds(0.1f);

        Wave5.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        Wave5.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -20);
        yield return new WaitForSeconds(0.1f);

        yield return null;
    }
}
