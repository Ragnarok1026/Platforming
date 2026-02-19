using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Bounce : MonoBehaviour
{
    public GameObject energy;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LeftWall"))
        {
            energy.transform.Translate(5f * Time.deltaTime, -3f * Time.deltaTime, 0f);
        }
    }
}
