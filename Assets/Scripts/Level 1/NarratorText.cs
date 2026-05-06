using TMPro;
using UnityEngine;
using System.Collections;

public class NarratorText : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;
    public GameObject textBox;
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
                textBox.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
            }
        }
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
