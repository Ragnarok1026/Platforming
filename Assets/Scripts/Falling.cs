using UnityEngine;

public class Falling : MonoBehaviour
{
    public float spinSpeed = 100f;
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);

    }
}
