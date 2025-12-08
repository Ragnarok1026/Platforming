using System.Collections;
using UnityEngine;

public class ShadowFight : MonoBehaviour
{
    public GameObject cutsceneStart;
    public GameObject Boss;
    public GameObject Player;
    public GameObject HoverPoint;
    public float speed;
    public bool fightStarted = false;
    void Start()
    {

    }
    void Update()
    {
        if(cutsceneStart == null && fightStarted == false)
        {
            Boss.GetComponent<Rigidbody2D>().gravityScale = -1;
            fightStarted = true;
        }
    }
}
