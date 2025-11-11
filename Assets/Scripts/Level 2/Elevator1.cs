using UnityEngine;

public class Elevator1 : MonoBehaviour
{
    public GameObject topStop;
    public GameObject bottomStop;
    public int speed = 4;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= topStop.transform.position.y)
        {
            speed = -speed;
        }
        else if (transform.position.y <= bottomStop.transform.position.y)
        {
            speed = -speed;
        }
    }
}