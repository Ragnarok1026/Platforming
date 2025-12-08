using UnityEngine;
using System.Collections;

public class ReleaseArrows : MonoBehaviour
{
    public GameObject Player;
    public GameObject Boss;
    public GameObject Shield;
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;
    public GameObject Arrow4;
    public GameObject Arrow5;
    public GameObject Arrow6;
    public float speed = 5f;
    private ShadowFight shadowFightScript;
    private StartShadow startShadowScript;  
    void Start()
    {
        shadowFightScript = GameObject.Find("FightController").GetComponent<ShadowFight>();
    }
    void Update()
    {
        if (shadowFightScript.fightStarted == true)
        {
            StartCoroutine(ReleaseArrow());
        }
    }
    IEnumerator ReleaseArrow()
    {
        yield return new WaitForSeconds(1f);
        Arrow1.SetActive(true);
        yield return new WaitForSeconds(1f);
        Arrow1.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(1f);
        Arrow2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Arrow2.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);

        yield return new WaitForSeconds(1f);
        Arrow3.SetActive(true);
        yield return new WaitForSeconds(1f);
        Arrow3.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(1f);
        Arrow4.SetActive(true);
        yield return new WaitForSeconds(1f);
        Arrow4.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);

        yield return new WaitForSeconds(1f);
        Arrow5.SetActive(true);
        yield return new WaitForSeconds(1f);
        Arrow5.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(1f);
        Arrow6.SetActive(true);
        yield return new WaitForSeconds(1f);
        Arrow6.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);

        yield return new WaitForSeconds(1f);
        Shield.SetActive(false);
        Boss.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        Boss.GetComponent<Rigidbody2D>().gravityScale = 1;

        yield return null;
    }
}
