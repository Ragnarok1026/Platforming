using TMPro;
using UnityEngine;
using System.Collections;

public class VoidEnters : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;
    public GameObject textBox;
    public GameObject player;
    public ParticleSystem voidWall;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) && textBox.activeSelf)
        {
            voidWall.Play();
            textBox.SetActive(false);
        }
    }
    public void voidAppears()
    {
        currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
        Animate();
    }
    public void Animate()
    {
        textBox.SetActive(true);
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
