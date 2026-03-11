using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class Boss2Health : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public Animator animator;
    public GameObject Shield;
    public GameObject Cam;
    public bool phaseTwo = false;
    public bool phaseThree = false;
    public bool finalPhase = false;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        animator.SetTrigger("Hurt");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Cam.GetComponent<AudioSource>().Stop();
            animator.SetBool("isDead", true);
        }
        if (currentHealth == 15)
        {
            animator.SetBool("isDead", false);
            Invoke("Rise1", 0.5f);
        }
        if (currentHealth == 10)
        {
            animator.SetBool("isDead", false);
            Invoke("Rise2", 0.5f);
        }
        if (currentHealth == 5)
        {
            animator.SetBool("isDead", false);
            Invoke("FinalPhase", 0.5f);
        }
    }
    void Rise1()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<BossFloat>().enabled = true;
        Shield.SetActive(true);
        Invoke("PhaseTwo", 2f);
    }
    void Rise2()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<BossFloat>().enabled = true;
        Shield.SetActive(true);
        Invoke("PhaseThree", 2f);
    }
    void PhaseTwo()
    {
        phaseTwo = true;
    }
    void PhaseThree()
    {
        phaseTwo = false;
        phaseThree = true;
    }
        public void FinalPhase()
        {
            phaseThree = false;
            finalPhase = true;
    }
}
