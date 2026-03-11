using UnityEngine;

public class LastPhase : MonoBehaviour
{
    public GameObject boss;
    public GameObject movePoint1;
    public GameObject movePoint2;
    public GameObject movePoint3;
    public GameObject Pillar1;
    public GameObject Pillar2;
    public GameObject Pillar3;
    void Start()
    {

    }
    void Update()
    {
        if (boss.GetComponent<Boss2Health>().finalPhase == true)
        {
            Invoke("FinalPhase", 0.5f);
        }
    }
    void FinalPhase()
    {
        boss.GetComponent<Rigidbody2D>().gravityScale = 0;
        boss.GetComponent<BossFloat>().enabled = true;
        boss.GetComponent<Boss2Health>().Shield.SetActive(true);
        Pillar1.transform.position = Vector3.MoveTowards(Pillar1.transform.position, movePoint1.transform.position, 5f * Time.deltaTime);
        Pillar2.transform.position = Vector3.MoveTowards(Pillar2.transform.position, movePoint2.transform.position, 5f * Time.deltaTime);
        Pillar3.transform.position = Vector3.MoveTowards(Pillar3.transform.position, movePoint3.transform.position, 5f * Time.deltaTime);
    }
}
