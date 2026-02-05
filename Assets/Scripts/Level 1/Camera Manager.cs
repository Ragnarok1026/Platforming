using System.Collections;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Switch cameras when the player exits the trigger area
        if (other.GetType() == typeof(BoxCollider2D) && other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(SwitchCamera());
        }
          
    }

    IEnumerator SwitchCamera()
    {
        // Wait for 1 second before switching cameras
        if (cam1.activeInHierarchy)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else if (cam2.activeInHierarchy)
        {
            cam2.SetActive(false);
            cam1.SetActive(true);
        }
        yield return new WaitForSeconds(1.0f);
    }
}
