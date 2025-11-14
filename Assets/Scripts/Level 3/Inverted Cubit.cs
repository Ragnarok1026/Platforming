using UnityEngine;
using System.Collections;

public class InvertedCubit : MonoBehaviour
{
    [SerializeField] private ParticleSystem ParticleSystem;
    private ParticleSystem ParticleSystem1;
    public GameObject Player;
    public GameObject Entity;
    public GameObject Shadow;
    public GameObject Particle;
    public GameObject Monolouge1;
    public GameObject Monolouge2;
    public GameObject Monolouge3;
    public GameObject Monolouge4;
    public GameObject Monolouge5;
    public Animator Animator1;
    public Animator Animator2;
    public bool cutscene1 = false;
    public bool cutscene2 = false;
    public bool cutscene3 = false;
    public bool cutscene4 = false;
    public bool EndShadow = false;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            Player.GetComponent<PlayerMovement>().enabled = false;
            Player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            Animator1.SetFloat("Speed", 0);
            Monolouge1.SetActive(true);
            StartCoroutine(EntityMonolouge());
        }
    }
    public IEnumerator EntityMonolouge()
    {
        while (cutscene1 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("Cutscene1", 0);
                cutscene1 = true;
            }
            yield return null;
        }
        while (cutscene2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene2 == false)
            {
                Invoke("Cutscene2", 0);
                cutscene2 = true;
            }
            yield return null;
        }
        while (cutscene3 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene3 == false)
            {
                Invoke("Cutscene3", 0);
                cutscene3 = true;
            }
            yield return null;
        }
        while(cutscene3 == true)
        {
            if(Input.GetKeyDown(KeyCode.Space) && cutscene3 == true)
            {
                Invoke("Creation1", 0);
                cutscene3 = false;
            }
            yield return null;
        }
        while(cutscene4 == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) && cutscene4 == false)
            {
                Invoke("Leaving", 0);
                cutscene4 = true;
            }
            yield return null;
        }

    }
    void Cutscene1()
    {
        Monolouge1.SetActive(false);
        Monolouge2.SetActive(true);
    }
    void Cutscene2()
    {
        Monolouge2.SetActive(false);
        Monolouge3.SetActive(true);
    }
    void Cutscene3()
    {
        Monolouge3.SetActive(false);
        Monolouge4.SetActive(true);
    }
    void Creation1()
    {
        Monolouge4.SetActive(false);
        Entity.GetComponent<Rigidbody2D>().gravityScale = -1f;
        Invoke("Creation2", 0.8f);
    }
    void Creation2()
    {
        Entity.GetComponent<Rigidbody2D>().gravityScale = 3f;
        Invoke("SpawnParticles", 1);
    }
    void SpawnParticles()
    {
        ParticleSystem1 = Instantiate(ParticleSystem, Particle.transform.position, Quaternion.identity);
        Invoke("SpawnShadow", 3);
    }
    void SpawnShadow()
    {
        Shadow.SetActive(true);
        Invoke("LastDialouge", 2);
    }
    void LastDialouge()
    {
        Monolouge5.SetActive(true);
        EndShadow = true;
    }
    void Leaving()
    {
        Monolouge5 .SetActive(false);
        Animator2.SetBool("IsLeaving", true);
        Invoke("IntoShadows", 1);
    }
    void IntoShadows()
    {
        Entity.GetComponent<BoxCollider2D>().isTrigger = true;
    }
}
