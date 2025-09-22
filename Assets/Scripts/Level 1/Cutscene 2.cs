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
        if (other.GetType() == typeof(BoxCollider2D) && other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, 0);
            animator.SetFloat("Speed", 0);
            Invoke("FloorGone", 0.7f);
        }
    }
    void FloorGone()
    {
            floor.SetActive(false);
    }
}
