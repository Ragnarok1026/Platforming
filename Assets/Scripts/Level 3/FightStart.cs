using UnityEngine;
using System.Collections;

public class FightStart : MonoBehaviour
{
    public int speed = 2;
    public GameObject startPoint;
    public GameObject allSpears;
    public GameObject Spear1;
    public GameObject Spear2;
    public GameObject Spear3;
    public GameObject Spear4;
    public GameObject Spear5;
    public GameObject Spear6;
    public GameObject Spear7;
    public GameObject Spear8;
    public GameObject Spear9;
    public GameObject Spear10;
    public GameObject Spear11;
    public GameObject Spear12;
    public GameObject Spear13;
    public GameObject Spear14;
    public bool spearsAppear = false;
    public bool spearsAttack = false;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate((startPoint.transform.position - transform.position) * speed * Time.deltaTime);
        Invoke("Appear", 2f);
        if (spearsAppear == true)
        {
            allSpears.SetActive(true);
            spearsAttack = true;
        }
        StartCoroutine(BloodSpears());
    }
    void Appear()
    {
        spearsAppear = true;
    }
    IEnumerator BloodSpears()
    {
        yield return new WaitForSeconds(2f);
        while (spearsAttack == true)
        {
            Debug.Log("Spears Attack");
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    }
}
