using UnityEngine;
using System.Collections;

public class NextPhase : MonoBehaviour
{
    public GameObject guard;
    public GameObject phaseStart;
    public GameObject floatPoint;
    void Start()
    {
        if(phaseStart == null)
        {
            GetComponent<Phase1>().enabled = false;
            guard.GetComponent<BossGuard>().enabled = true;
            transform.position = Vector3.MoveTowards(transform.position, floatPoint.transform.position, 10f * Time.deltaTime);
        }
    }
    void Update()
    {
        
    }
    IEnumerator Phase2()
    {
        yield return null;
    }
}
