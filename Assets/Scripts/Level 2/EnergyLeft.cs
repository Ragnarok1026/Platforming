using UnityEngine;

public class EnergyLeft : MonoBehaviour
{
    private int EnergyCount;
    public int MaxEnergy;
    public GameObject shield;
    void Start()
    {
        EnergyCount = MaxEnergy;
    }
    void Update()
    {
        if(MaxEnergy <= 0)
        {
            shield.SetActive(false);
        }
    }
    public void DestroyEnergy(int defeat)
    {
        MaxEnergy -= defeat;
    }
}
