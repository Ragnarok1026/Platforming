using UnityEngine;

public class BossFloat : MonoBehaviour
{
    private float speed = 10f;
    private float rotationSpeed = 200f;
    public GameObject energy;
    public GameObject FightStart;
    public GameObject phase1;
    public GameObject floatPoint;
    public GameObject shield;
    public GameObject vineOne;
    public GameObject vineTwo;
    public GameObject vineStopOne;
    public GameObject vineStopTwo;
    void Start()
    {
        
    }
    void Update()
    {
        if (FightStart == null)
        {
            transform.position = Vector3.MoveTowards(transform.position, floatPoint.transform.position, speed * Time.deltaTime);
            vineOne.transform.position = Vector3.MoveTowards(vineOne.transform.position, vineStopOne.transform.position, speed * Time.deltaTime);
            vineTwo.transform.position = Vector3.MoveTowards(vineTwo.transform.position, vineStopTwo.transform.position, speed * Time.deltaTime);
        }
        if (transform.position == floatPoint.transform.position)
        {
            shield.SetActive(true);
            energy.SetActive(true);
            GetComponent<BoxCollider2D>().isTrigger = true;
            shield.transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
            Destroy(phase1);
        }
    }
}
