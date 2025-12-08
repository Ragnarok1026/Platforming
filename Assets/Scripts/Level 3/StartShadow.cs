using UnityEngine;

public class StartShadow : MonoBehaviour
{
    public GameObject Boss;
    public GameObject Shield;
    public float shieldSpeed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shield.transform.Rotate(Vector3.forward * shieldSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shadow")
        {
            Boss.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            Shield.SetActive(true);
        }
    }
}
