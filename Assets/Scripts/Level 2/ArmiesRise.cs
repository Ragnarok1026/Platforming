using UnityEngine;

public class ArmiesRise : MonoBehaviour
{
    public GameObject floatPoint;
    public GameObject boss;
    public GameObject Attack1;
    void Start()
    {

    }
    void FixedUpdate()
    {
        if (boss.transform.position == floatPoint.transform.position)
        {
            Attack1.SetActive(true);
            Invoke("AttackOne", 1f);
        }
    }
    void AttackOne()
    {
        Attack1.transform.Translate(Vector2.left * 100 * Time.deltaTime);
    }
}
