using TMPro;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComingSoonText : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;
    public GameObject textBox;
    void Start()
    {
        Animate();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            if (currentDisplayingText == 0 && itemInfoText.text == itemInfo[0])
            {
                currentDisplayingText = (currentDisplayingText + 1);
                Animate();
            }
            else if (currentDisplayingText == 1 && itemInfoText.text == itemInfo[1])
            {
                currentDisplayingText = (currentDisplayingText + 1);
                Animate();
            }
            else if (currentDisplayingText == 2 && itemInfoText.text == itemInfo[2])
            {
                currentDisplayingText = (currentDisplayingText + 1);
                textBox.SetActive(true);
                Animate();
            }
            else if (currentDisplayingText == 3 && itemInfoText.text == itemInfo[3])
            {
                currentDisplayingText = (currentDisplayingText + 1);
                textBox.SetActive(false);
                Animate();
            }
            else if (currentDisplayingText == 4 && itemInfoText.text == itemInfo[4])
            {
                currentDisplayingText = (currentDisplayingText + 1);
                Animate();
            }
            else if (currentDisplayingText == 5 && itemInfoText.text == itemInfo[5])
            {
                SceneManager.LoadScene("MainMenu");
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
