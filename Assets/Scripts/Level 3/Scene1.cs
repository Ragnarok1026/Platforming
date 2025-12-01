using UnityEngine;

public class Scene1 : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("StartCutscene"))
        {
            Debug.Log("Cutscene started");
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            GetComponent<PlayerMovement>().enabled = false;
            Invoke("Cutscene", 2f);
        }
    }
    void Cutscene()
    {
        Debug.Log("Cutscene started");
    }
}
