using UnityEngine;
using System.Collections;

public class ReleaseArrows : MonoBehaviour
{
    public GameObject Arrow1;
    public float speed = 5f;
    private ShadowFight shadowFightScript;
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
        yield return new WaitForSeconds(0.5f);
        Arrow1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Arrow1.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
        yield return null;
    }
}
