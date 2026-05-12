using Unity.Cinemachine;
using UnityEngine;

public class DestroyEnergy : MonoBehaviour
{
    public GameObject shieldManager;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Energy"))
        {
            collision.gameObject.SetActive(false);
            shieldManager.GetComponent<EnergyLeft>().DestroyEnergy(1);
        }
    }
}
