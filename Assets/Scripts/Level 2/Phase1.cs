using UnityEngine;

public class Phase1 : MonoBehaviour
{
    public GameObject energy;
    public GameObject startFight;
    void Start()
    {
        
    }
    void Update()
    {
        if (startFight == null)
        {
            energy.SetActive(true);
            energy.transform.Translate(-5f * Time.deltaTime, -5f * Time.deltaTime, 0f);
        }
    }
}
