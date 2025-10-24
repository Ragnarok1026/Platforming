using UnityEngine;
using System.Collections;

public class BossFight2 : MonoBehaviour
{
    public GameObject endCutscene;
    public GameObject player;
    public GameObject boss;
    public float speed;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if(endCutscene.activeInHierarchy == false)
        {
            Invoke("BossFight", 0f);
        }
    }
    void BossFight()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            speed = 0;
        }
    }

    public IEnumerator Attack()
    {
        while(speed == 0)
        {
            
            yield return null;
        }
    }
}
