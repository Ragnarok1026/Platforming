using UnityEngine;

public class NextRoom : MonoBehaviour
{
    private int EnemyCount;
    public int MaxEnemies;
    public GameObject Door;
    public GameObject LevelLoad;
    void Start()
    {
        EnemyCount = MaxEnemies;
    }

    void Update()
    {
        if (MaxEnemies == 0)
        {
            Door.SetActive(false);
            LevelLoad.SetActive(true);
        }

    }

    public void DefeatEnemy(int defeat)
    {
        MaxEnemies -= defeat;
    }
}
