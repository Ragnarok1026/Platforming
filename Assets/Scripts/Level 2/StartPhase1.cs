using UnityEngine;

public class StartPhase1 : MonoBehaviour
{
    public GameObject startFight;
    public GameObject energy;
    void Start()
    {
        
    }
    void Update()
    {
        if (startFight == null)
        {
            energy.SetActive(true);
        }
    }
}
