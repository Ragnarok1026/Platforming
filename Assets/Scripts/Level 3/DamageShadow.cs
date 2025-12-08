using UnityEngine;

public class DamageShadow : MonoBehaviour
{
    private ShadowHealth shadowHealthScript;
    void Start()
    {
      
    }
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Shadow")
        {
            shadowHealthScript.TakeDamage(1);
        }
    }
}
