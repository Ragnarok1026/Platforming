using UnityEngine;
using System.Collections;

public class FightStart : MonoBehaviour
{
    public int speed = 2;
    public int SpearSpeed = 1;
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

    public GameObject Perish;

    public bool spearsAppear = false;
    public bool spearsAttack = false;
    public bool die = false;
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
            StartCoroutine(Spears());
        }

    }
    void Appear()
    {
        spearsAppear = true;
    }
    IEnumerator Spears()
    {
        while (die == false)
        {
            if (spearsAppear == true && die == false)
            {
                Perish.SetActive(true);
                yield return new WaitForSeconds(1);
                die = true;
            }
            yield return null;
        }
        while (die == true)
        {
            if (spearsAppear == true && die == true)
            {
                Perish.SetActive(false);
                Spear1.transform.Translate(Vector2.right * SpearSpeed * Time.deltaTime);
                Spear2.transform.Translate(Vector2.right * SpearSpeed * Time.deltaTime);
                Spear3.transform.Translate(Vector2.right * SpearSpeed * Time.deltaTime);
                Spear4.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear5.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear6.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear7.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear8.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear9.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear10.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear11.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear12.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear13.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                Spear14.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                yield return null;
            }
            yield return null;
        }
    }
}
