using System.Collections;
using UnityEngine;

public class FinalPhase : MonoBehaviour
{
    private StartShadow startShadowScript;
    private ShadowHealth shadowHealthScript;
    public GameObject Shadow;
    void Start()
    {
        shadowHealthScript = GameObject.Find("Shadow").GetComponent<ShadowHealth>();
        startShadowScript = GameObject.Find("HoverPoint").GetComponent<StartShadow>();
    }
    void Update()
    {
        if(shadowHealthScript.currentHealth == 1)
        {
            startShadowScript.enabled = true;
            Invoke("DisableGravity", 0f);
        }
    }
    void DisableGravity()
    {
        Shadow.GetComponent<Rigidbody2D>().gravityScale = -1;
        StartCoroutine(LastPhase());
    }
    IEnumerator LastPhase()
    {
        Debug.Log("Final Phase Started");
        yield return null;
    }
}
