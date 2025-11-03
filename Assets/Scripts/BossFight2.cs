using UnityEngine;
using System.Collections;

public class BossFight2 : MonoBehaviour
{
    public GameObject endCutscene;
    public Animator animator;
    public GameObject player;
    public GameObject boss;
    public GameObject attackPointA;
    public GameObject attackPointB;
    public GameObject attackPointStart;
    public GameObject attack;
    public float speed;
    public bool attackPhase1 = false;
    public bool charging = false;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if(attackPhase1 == false && endCutscene == null)
        {
            attackPhase1 = true;
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        while(attackPhase1 == true)
        {
            while (Vector2.Distance(transform.position, attackPointA.transform.position) > 1f)
            {
                speed = 1f;
                transform.Translate((attackPointA.transform.position - transform.position) * speed * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForSeconds(1.5f);

            while(Vector2.Distance(transform.position, attackPointB.transform.position) > 1f)
            {
                speed = 1f;
                transform.Translate((attackPointB.transform.position - transform.position) * speed * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForSeconds(1.5f);

            while(Vector2.Distance(transform.position, attackPointStart.transform.position) > 1f)
            {
                speed = 2f;
                transform.Translate((attackPointStart.transform.position - transform.position) * speed * Time.deltaTime);   
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForSeconds(3);
        }
    }
}
