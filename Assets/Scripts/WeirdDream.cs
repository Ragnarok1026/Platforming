using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class WeirdDream : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    void Update()
    {
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetType() == typeof(BoxCollider2D) && other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Dream());
        }
    }
    IEnumerator Dream()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("WeirdDream");
        animator.SetTrigger("End");
    }
}
