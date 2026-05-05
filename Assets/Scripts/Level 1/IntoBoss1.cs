using UnityEngine;

public class IntoBoss1 : MonoBehaviour
{
    private int EnemyCount;
    public int MaxEnemies;
    public GameObject Cam;
    public GameObject Player;
    public GameObject Door;
    public GameObject LevelLoad;
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
            Cam.GetComponent<AudioSource>().Play();
            Player.GetComponent<AudioSource>().Stop();
        }

    }

    public void DefeatEnemy(int defeat)
    {
        // Decrease the enemy count when an enemy is defeated
        MaxEnemies -= defeat;
    }
}
