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
        EnemyCount = MaxEnemies;
    }

    void Update()
    {
        if (MaxEnemies == 0)
        {
            Door.SetActive(false);
            LevelLoad.SetActive(true);
            Text1.SetActive(false);
            Text2.SetActive(true);
        }

    }

    public void DefeatEnemy(int defeat)
    {
        MaxEnemies -= defeat;
    }
}
