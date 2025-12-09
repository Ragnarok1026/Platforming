using System.Collections;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Phase2 : MonoBehaviour
{
    private ShadowFight shadowFightScript;
    private StartShadow startShadowScript;
    private ShadowHealth shadowHealthScript;
    public GameObject WaveOne;
    public GameObject WaveTwo;
    public GameObject WaveThree;
    public GameObject WaveFour;
    public GameObject WaveFive;
    public GameObject WaveSix;
    public GameObject Boss;
    public GameObject Shield;
    public float speed = 10f;
    void Start()
    {
        shadowFightScript = GameObject.Find("FightController").GetComponent<ShadowFight>();
        shadowHealthScript = GameObject.Find("Shadow").GetComponent<ShadowHealth>();
        startShadowScript = GameObject.Find("HoverPoint").GetComponent<StartShadow>();
    }
    void Update()
    {
        if(shadowHealthScript.currentHealth == 2)
        {
            shadowFightScript.fightStarted = false;
            startShadowScript.enabled = true;
            StartCoroutine(SecondPhase());
        }
    }
    IEnumerator SecondPhase()
    {
        yield return new WaitForSeconds(1f);
        WaveOne.SetActive(true);
        yield return new WaitForSeconds(1f);
        WaveOne.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(0.5f);
        WaveTwo.SetActive(true);
        yield return new WaitForSeconds(1f);
        WaveTwo.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(0.5f);
        WaveThree.SetActive(true);
        yield return new WaitForSeconds(1f);
        WaveThree.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(0.5f);
        WaveFour.SetActive(true);
        yield return new WaitForSeconds(1f);
        WaveFour.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(0.3f);
        WaveFive.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        WaveFive.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(0.3f);
        WaveSix.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        WaveSix.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);

        yield return new WaitForSeconds(1f);
        Destroy(shadowFightScript);
        Boss.GetComponent<Rigidbody2D>().constraints &= ~RigidbodyConstraints2D.FreezePositionX;
        Boss.GetComponent<Rigidbody2D>().constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        Boss.GetComponent<Rigidbody2D>().gravityScale = 1;
        Shield.SetActive(false);

        if (shadowHealthScript.currentHealth == 1)
        {
            ReleaseArrows.Destroy(this);
        }
        yield return null;
    }
}
