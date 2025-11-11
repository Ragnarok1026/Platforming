using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    public int EnemiesRemaining;
    private int MaxEnemies = 16;
    private bool isOpen = false;

    void Start()
    {
        EnemiesRemaining = MaxEnemies;
    }
    void Update()
    {
        if (EnemiesRemaining == 0)
        {
            isOpen = true;
        }
        if (isOpen == true)
        {
            door.SetActive(false);
        }
    }
    public void EnemyDefeated(int Defeated)
    {
        EnemiesRemaining -= Defeated;
    }
}
