using UnityEngine;

public class EnterBossRoom3 : MonoBehaviour
{
    public EnemiesRemaining enemies;
    public GameObject bossDoor;
    void Start()
    {
        
    }
    void Update()
    {
        if (enemies.MaxEnemies == 0)
        {
            bossDoor.SetActive(true);
        }
    }
}
