using UnityEngine;

public class EnemiesRemaining : MonoBehaviour
{
    private int EnemyCount;
    public int MaxEnemies;
    public GameObject Door;
    void Start()
    {
        EnemyCount = MaxEnemies;
    }

    void Update()
    {
        if(MaxEnemies == 0)
        {
            Door.SetActive(false);
        }

    }

    public void DefeatEnemy(int defeat)
    {
        MaxEnemies -= defeat;
    }
}
