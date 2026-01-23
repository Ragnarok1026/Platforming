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
    public float speed = 150f;
    void Start()
    {

    }
    void Update()
    {
        if (start == null)
        {
            transform.position = Vector3.MoveTowards(transform.position, hover.transform.position, 5f * Time.deltaTime);
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
        yield return new WaitForSeconds(2f);
        warning1.SetActive(true);
        warning2.SetActive(true);
        yield return new WaitForSeconds(2f);
        warning1.SetActive(false);
        warning2.SetActive(false);
        vines1.transform.position = Vector3.MoveTowards(vines1.transform.position, stop1.transform.position, 3f * Time.deltaTime);
        vines2.transform.position = Vector3.MoveTowards(vines2.transform.position, stop2.transform.position, 3f * Time.deltaTime);
        yield return null;
    }
}
