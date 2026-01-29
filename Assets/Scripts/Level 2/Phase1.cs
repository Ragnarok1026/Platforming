using UnityEngine;
using System.Collections;

public class Phase1 : MonoBehaviour
{
    public float speed = 10f;
    public GameObject startFight;
    public GameObject endFight;
    public GameObject phaseEnd;
    public GameObject guard;
    public GameObject phase2;
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;
    public GameObject Arrow4;
    public GameObject Arrow5;
    public GameObject Arrow6;
    public GameObject Arrow7;
    public GameObject Arrow8;
    public GameObject Arrow9;
    public GameObject Arrow10;
    public GameObject Arrow11;
    void Start()
    {
        
    }
    void Update()
    {
        if(startFight == null)
        {
            GetComponent<BossGuard>().enabled = false;
            StartCoroutine(Arrows());
        }
    }
    IEnumerator Arrows()
    {
        Arrow1.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow2.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow3.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow4.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow5.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow6.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow7.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow8.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.2f);
        Arrow9.GetComponent<Rigidbody2D>().gravityScale = 5;
        yield return new WaitForSeconds(0.5f);
        phase2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Arrow10.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(speed, 0);
        yield return new WaitForSeconds(1f);
        Arrow11.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
        yield return new WaitForSeconds(1f);
        guard.SetActive(false);
        transform.position = Vector3.MoveTowards(transform.position, endFight.transform.position, 5f * Time.deltaTime);
        yield return new WaitForSeconds(5f);
        Destroy(phaseEnd);
        GetComponent<Phase1>().enabled = false;
        yield return null;
    }
}
