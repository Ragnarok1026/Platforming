using UnityEngine;
using System.Collections;

public class BossFight2 : MonoBehaviour
{
    public GameObject endCutscene;
    public GameObject player;
    public GameObject boss;
    public GameObject attackPointA;
    public GameObject attackPointB;
    public GameObject attackPointStart;
    public float speed;
    public bool attackPhase1 = false;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if(endCutscene.activeInHierarchy == false)
        {
            attackPhase1 = true;
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        while(attackPhase1 == true)
        {
            transform.Translate((attackPointA.transform.position - transform.position) * speed * Time.deltaTime);
            yield return new WaitForSeconds(3);

            transform.Translate((attackPointB.transform.position - transform.position) * speed * Time.deltaTime);
            yield return new WaitForSeconds(3);

            transform.Translate((attackPointStart.transform.position - transform.position) * speed * Time.deltaTime);   
            yield return new WaitForSeconds(3);
        }
    }
}
