using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene2 : MonoBehaviour
{
    public GameObject player;
    public GameObject cutsceneStart;
    public GameObject floor;
    public Animator animator;
    void Update()
    {
        

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        // Trigger cutscene when the player exits the trigger area
        if (other.GetType() == typeof(BoxCollider2D) && other.gameObject.CompareTag("Player"))
        {
            // Activate cutscene start object
            player.GetComponent<PlayerMovement>().enabled = false;
            // Stop player movement
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            // Disable player movement script
            animator.SetFloat("Speed", 0);
            // Set animator speed to 0
            Invoke("FloorGone", 0.7f);
        }
    }
    void FloorGone()
    {
        // Deactivate the floor object to simulate it disappearing
        floor.SetActive(false);
    }
}
