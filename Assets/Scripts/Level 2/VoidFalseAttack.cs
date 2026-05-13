using UnityEngine;

public class VoidFalseAttack : MonoBehaviour
{
    public GameObject player;
    public VoidEnters voidEnters;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            voidEnters.textBox.SetActive(true);
            voidEnters.voidAppears();
        }
    }
}
