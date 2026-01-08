using UnityEngine;

public class BossDoor : MonoBehaviour
{
    private int EnemyCount;
    public int MaxEnemies;
    public GameObject Door;
    public GameObject LevelLoad;
    void Start()
    {
        // Initialize the enemy count to the maximum number of enemies
        EnemyCount = MaxEnemies;
    }

    void Update()
    {
        // Check if all enemies have been defeated
        if (MaxEnemies == 0)
        {
            Door.SetActive(false);
            LevelLoad.SetActive(true);
        }

    }

    public void DefeatEnemy(int defeat)
    {
        // Decrease the enemy count when an enemy is defeated
        // Decrease the enemy count when an enemy is defeated
        MaxEnemies -= defeat;
    }
}
