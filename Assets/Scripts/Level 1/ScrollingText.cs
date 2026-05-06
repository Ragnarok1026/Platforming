using UnityEngine;
using TMPro;
using System.Collections;

public class ScrollingText : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;
    public GameObject textBox;
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;
    public GameObject player;

    void Start()
    {
       player.GetComponent<PlayerMovement>().enabled = false;
        Animate();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            if (currentDisplayingText == 0 && itemInfoText.text == itemInfo[0])
            {
                NextText1();
            }
            if (currentDisplayingText == 1 && itemInfoText.text == itemInfo[1])
            {
                textBox.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
            }
            if (currentDisplayingText == 2 && itemInfoText.text == itemInfo[2])
            {
                textBox.SetActive(false);
                trigger1.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
            }
            if (currentDisplayingText == 3 && itemInfoText.text == itemInfo[3])
            {
                textBox.SetActive(false);
                trigger2.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
            }
            if (currentDisplayingText == 4 && itemInfoText.text == itemInfo[4])
            {
                textBox.SetActive(false);
                trigger3.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
            }
            if (currentDisplayingText == 5 && itemInfoText.text == itemInfo[5])
            {
                textBox.SetActive(false);
                trigger4.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }
    public void Animate()
    {
        StartCoroutine(AnimateText());
    }

    public void NextText1()
    {
        currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
        Animate();
    }

    public void NextText2()
    {
        currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        Animate();
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
