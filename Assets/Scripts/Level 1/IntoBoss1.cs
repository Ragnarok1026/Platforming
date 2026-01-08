using UnityEngine;

public class IntoBoss1 : MonoBehaviour
{
    private int EnemyCount;
    public int MaxEnemies;
    public GameObject Door;
    public GameObject LevelLoad;
    public GameObject Text1;
    public GameObject Text2;
    void Start()
    {
        // Initialize the current enemy count to the maximum number of enemies
        EnemyCount = MaxEnemies;
    }

    void Update()
    {
        // Check if all enemies have been defeated
        if (MaxEnemies == 0)
        {
            // Deactivate the door and activate the level load point
            Door.SetActive(false);
            LevelLoad.SetActive(true);
            Text1.SetActive(false);
            Text2.SetActive(true);
        }

    }

    public void DefeatEnemy(int defeat)
    {
        // Decrease the enemy count when an enemy is defeated
        MaxEnemies -= defeat;
    }
}
