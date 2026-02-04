using UnityEngine;

public class VinesRise : MonoBehaviour
{
    public float speed = 10f;
    public GameObject vine1;
    public GameObject vine2;
    public GameObject vineStop1;
    public GameObject vineStop2;
    public GameObject rise;
    void Start()
    {

    }
    void Update()
    {

        if (rise = null)
        {
            vine1.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
