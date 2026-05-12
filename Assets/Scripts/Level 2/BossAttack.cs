using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public BossHealth2 bossHealth;
    public Phase1Start phase1Start;
    public GameObject bossHelp1;
    public GameObject bossHelp2;
    public GameObject bossHelp3;
    void Start()
    {
        
    }
    void Update()
    {
        if (bossHealth.currentHealth == 30 && phase1Start.phase1Started == true)
        {
            Invoke("Phase1", 0.5f);
        }
    }

    void Phase1()
    {
        bossHelp1.SetActive(true);
        bossHelp2.SetActive(true);
        bossHelp3.SetActive(true);
    }
}
