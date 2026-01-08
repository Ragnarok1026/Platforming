using UnityEngine;

public class Clouds : MonoBehaviour
{
    public GameObject clouds;
    public int speed = 2;
    void Update()
    {
        // Move clouds upward continuously
        clouds.transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
