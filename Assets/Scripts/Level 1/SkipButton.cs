using UnityEngine;
using UnityEngine.InputSystem;

public class SkipButton : MonoBehaviour
{
    public ScrollingText text;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnSkip(InputValue value)
    {
        if (text.currentDisplayingText == 0 && text.itemInfoText.text == text.itemInfo[0])
        {
            text.NextText1();
        }
        if (text.currentDisplayingText == 1 && text.itemInfoText.text == text.itemInfo[1])
        {
            text.textBox.SetActive(false);
            text.player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (text.currentDisplayingText == 2 && text.itemInfoText.text == text.itemInfo[2])
        {
            text.textBox.SetActive(false);
            text.trigger1.SetActive(false);
            text.player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (text.currentDisplayingText == 3 && text.itemInfoText.text == text.itemInfo[3])
        {
            text.textBox.SetActive(false);
            text.trigger2.SetActive(false);
            text.player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (text.currentDisplayingText == 4 && text.itemInfoText.text == text.itemInfo[4])
        {
            text.textBox.SetActive(false);
            text.trigger3.SetActive(false);
            text.player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (text.currentDisplayingText == 5 && text.itemInfoText.text == text.itemInfo[5])
        {
            text.textBox.SetActive(false);
            text.trigger4.SetActive(false);
            text.player.GetComponent<PlayerMovement>().enabled = true;
        }
    }
}
