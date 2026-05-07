using TMPro;
using UnityEngine;
using System.Collections;

public class BossText : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;
    public GameObject textBox;
    public GameObject trigger;
    public GameObject player;
    public GameObject boss;
    public GameObject door;

    void Start()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        Animate();
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
                player.GetComponent<PlayerMovement>().enabled = true;
                boss.GetComponent<BossGoUp>().enabled = true;
            }
            if (currentDisplayingText == 3 && itemInfoText.text == itemInfo[3])
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                player.GetComponent<PlayerMovement>().enabled = false;
                Animate();
            }
            if (currentDisplayingText == 4 && itemInfoText.text == itemInfo[4])
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                Animate();
            }
            if (currentDisplayingText == 5 && itemInfoText.text == itemInfo[5])
            {
                textBox.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
                boss.GetComponent<BossGoUp>().enabled = true;
                Destroy(boss);
                Destroy(door);
            }
        }
    }
    public void ShowText()
    {
        currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
        Animate();
    }
    public void Animate()
    {
        StartCoroutine(AnimateText());
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
