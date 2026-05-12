using UnityEngine;

public class Phase1Start : MonoBehaviour
{
    public StartBossCutscene startBossCutscene;
    public GameObject boss;
    public GameObject teleportEffect;
    public GameObject teleportPoint;
    public GameObject shield;
    public bool phase1Started = false;
    void Start()
    {
        
    }
    void Update()
    {
        if(startBossCutscene.endCutscene == true)
        {
            boss.transform.position = teleportPoint.transform.position;
            boss.SetActive(true);
            Invoke("BossPhase1Starts", 0.1f);
        }
    }
    void BossPhase1Starts()
    {
        teleportEffect.SetActive(false);
        shield.SetActive(true);
        phase1Started = true;
        this.gameObject.SetActive(false);
    }
}
