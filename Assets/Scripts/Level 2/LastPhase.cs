using UnityEngine;

public class LastPhase : MonoBehaviour
{
    public GameObject boss;
    public GameObject ragePoint;
    public GameObject shield;
    public float rotationSpeed;
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
        Invoke("Rage", 2f);
    }
    void Rage()
    {
        boss.GetComponent<BossFloat>().enabled = false;
        boss.GetComponent<Rigidbody2D>().gravityScale = 0;
        boss.transform.position = Vector2.MoveTowards(boss.transform.position, ragePoint.transform.position, 50f * Time.deltaTime);
        shield.transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        Invoke("Terminate", 1f);
    }
    void Terminate()
    {
        Destroy(this.gameObject);
    }
}
