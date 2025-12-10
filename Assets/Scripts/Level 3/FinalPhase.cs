using System.Collections;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class FinalPhase : MonoBehaviour
{
    private StartShadow startShadowScript;
    private ShadowHealth shadowHealthScript;
    private ShadowFight shadowFightScript;
    public GameObject Wave1;
    public GameObject Wave2;
    public GameObject Wave3;
    public GameObject Wave4;
    public GameObject Wave5;
    public GameObject Wave6;
    public GameObject Wave7;
    public GameObject Wave8;
    public GameObject Wave9;
    public GameObject Wave10;
    public GameObject Shadow;
    public GameObject Shield;
    public float speed = 15f;
    void Start()
    {
        shadowHealthScript = GameObject.Find("Shadow").GetComponent<ShadowHealth>();
        startShadowScript = GameObject.Find("HoverPoint").GetComponent<StartShadow>();
        shadowFightScript = GameObject.Find("FightController").GetComponent<ShadowFight>();
    }
    void Update()
    {
        if(shadowHealthScript.currentHealth == 1)
        {
            shadowFightScript.enabled = true;
            shadowFightScript.fightStarted = false;
            startShadowScript.enabled = true;
            StartCoroutine(LastPhase());
        }
    }
    IEnumerator LastPhase()
    {
        yield return new WaitForSeconds(1f);
        Wave1.SetActive(true);
        yield return new WaitForSeconds(1f);
        Wave1.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -speed);

        yield return new WaitForSeconds(0.5f);
        Wave2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Wave2.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -speed);

        yield return new WaitForSeconds(0.5f);
        Wave3.SetActive(true);
        yield return new WaitForSeconds(1f);
        Wave3.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(0.5f);
        Wave4.SetActive(true);
        yield return new WaitForSeconds(1f);
        Wave4.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);

        yield return new WaitForSeconds(0.5f);
        Wave5.SetActive(true);
        Wave6.SetActive(true);
        yield return new WaitForSeconds(1f);
        Wave5.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
        Wave6.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);

        yield return new WaitForSeconds(0.5f);
        Wave7.SetActive(true);
        Wave8.SetActive(true);
        yield return new WaitForSeconds(1f);
        Wave7.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
        Wave8.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);

        yield return new WaitForSeconds(0.5f);
        Wave9.SetActive(true);
        Wave10.SetActive(true);
        yield return new WaitForSeconds(1f);
        Wave9.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
        Wave10.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);

        yield return new WaitForSeconds(1f);
        Shadow.GetComponent<Rigidbody2D>().constraints &= ~RigidbodyConstraints2D.FreezePositionX;
        Shadow.GetComponent<Rigidbody2D>().constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        shadowFightScript.enabled = false;
        Shadow.GetComponent<Rigidbody2D>().gravityScale = 1;
        Shield.SetActive(false);

        yield return null;
    }
}
