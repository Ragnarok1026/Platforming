using TMPro;
using UnityEngine;
using System.Collections;

public class StartBossCutscene : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;
    public GameObject textBox;
    public GameObject player;
    public GameObject boss;
    public GameObject bossTeleport;
    public bool endCutscene = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) && textBox.activeSelf)
        {
            if (currentDisplayingText == 0 && itemInfoText.text == itemInfo[0])
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                Animate();
            }
            if (currentDisplayingText == 1 && itemInfoText.text == itemInfo[1])
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                Animate();
            }
            if (currentDisplayingText == 2 && itemInfoText.text == itemInfo[2])
            {
                textBox.SetActive(false);
                bossTeleport.SetActive(true);
                Invoke("TeleportBossOut", 0.1f);
                player.GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            Invoke("BossAppears", 1.5f);
        }
    }
    void BossAppears()
    {
        boss.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
        Invoke("Animate", 0.5f);
        Invoke("BossTeleportsIn", 0.1f);
    }
    public void Animate()
    {
        textBox.SetActive(true);
        StartCoroutine(AnimateText());
    }
    void BossTeleportsIn()
    {
        bossTeleport.SetActive(false);
    }
    void TeleportBossOut()
    {
        boss.SetActive(false);
        endCutscene = true;
    }
    IEnumerator AnimateText()
    {
        for (int i = 0; i < itemInfo[currentDisplayingText].Length + 1; i++)
        {
            itemInfoText.text = itemInfo[currentDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(textSpeed);
        }
    }
}