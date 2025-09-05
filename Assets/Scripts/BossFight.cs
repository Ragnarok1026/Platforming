using UnityEngine;

public class BossFight : MonoBehaviour
{
    public GameObject Boss;
    public bool fightStart = false;
    void Update()
    {

        fightStart = true;
        if(fightStart == true)
        {
            Boss.GetComponent<Rigidbody2D>().gravityScale = -1;
        }
    }
}
