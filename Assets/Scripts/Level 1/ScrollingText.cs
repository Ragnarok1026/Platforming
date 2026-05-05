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
    public GameObject player;
    public GameObject textTrigger1;

    private bool text1Finished = false;

    void Start()
    {
       player.GetComponent<PlayerMovement>().enabled = false;
        Animate();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextText1();
            text1Finished = true;
        }
    }
    public void NextText1()
    {
        currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
        Animate();
        if (Input.GetKeyDown(KeyCode.Space) && currentDisplayingText == 1)
        {
            EndText1();
            player.GetComponent<PlayerMovement>().enabled = true;
        }
    }
    public void EndText1()
    {
        textBox.SetActive(false);
        this.enabled = false;
    }
    public void NextText2()
    {
        currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        if(Input.GetKeyDown(KeyCode.Space))
            Animate();
    }
    public void EndText2()
    {
        textBox.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = true;
        textTrigger1.SetActive(false);
        this.enabled = false;
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
