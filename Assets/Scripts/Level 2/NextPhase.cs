using UnityEngine;
using System.Collections;

public class NextPhase : MonoBehaviour
{
    public GameObject guard;

    public GameObject phaseStart;
    public GameObject floatPoint;
    private Boss2Death boss2Death;
    void Start()
    {
        if(phaseStart == null)
        {
            StartCoroutine(Phase2());
        }
        boss2Death = FindAnyObjectByType<Boss2Death>();
    }
    void Update()
    {
        
    }
    IEnumerator Phase2()
    {
        yield return new WaitForSeconds(1f);
        if (boss2Death.currentHealth == 15)
        {
            yield return new WaitForSeconds(1f);    
            transform.position = Vector3.MoveTowards(transform.position, floatPoint.transform.position, 10f * Time.deltaTime);
        }
        yield return null;
    }
}
