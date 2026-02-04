using UnityEngine;

public class StopVine : MonoBehaviour
{
    public GameObject vineStop;
    void Start()
    {

    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Stop"))
        {
            vineStop.GetComponent<VinesRise>().speed = 0f;
        }
    }
}
