using UnityEngine;
using System.Collections;

public class BossGuard : MonoBehaviour
{
    public GameObject start;
    public GameObject hover;
    public GameObject guard;
    public GameObject warning1;
    public GameObject warning2;
    public GameObject vines1;
    public GameObject vines2;
    public GameObject stop1;
    public GameObject stop2;
    public GameObject startBoss;
    public GameObject Stage1;
    public GameObject startFight;
    public float speed = 150f;
    void Start()
    {

    }
    void Update()
    {
        if (start == null)
        {
            transform.position = Vector3.MoveTowards(transform.position, hover.transform.position, 10f * Time.deltaTime);
        }
        if(Vector3.Distance(transform.position, hover.transform.position) < 0.1f)
        {
            guard.SetActive(true);
            guard.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            StartCoroutine(Warning());
        }
    }
    IEnumerator Warning()
    {
        yield return new WaitForSeconds(0f);
        warning1.SetActive(true);
        warning2.SetActive(true);
        yield return new WaitForSeconds(1f);
        warning1.GetComponent<SpriteRenderer>().enabled = false;
        warning2.GetComponent<SpriteRenderer>().enabled = false;
        vines1.transform.position = Vector3.MoveTowards(vines1.transform.position, stop1.transform.position, 10f * Time.deltaTime);
        vines2.transform.position = Vector3.MoveTowards(vines2.transform.position, stop2.transform.position, 10f * Time.deltaTime);
        yield return new WaitForSeconds(2f);
        Destroy(startBoss);
        Stage1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Destroy(startFight);
        yield return null;
    }
}
