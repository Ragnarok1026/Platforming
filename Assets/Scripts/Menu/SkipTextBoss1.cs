using UnityEngine;

public class SkipText : MonoBehaviour
{
    public NarratorText narratorText;
    public BossText bossText;
    public LevelOneEndText levelOneEndText;
    public bool bossDefeated = false;   
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnSkip()
    {
        if (narratorText.currentDisplayingText == 0 && narratorText.itemInfoText.text == narratorText.itemInfo[0])
        {
            narratorText.textBox.SetActive(false);
            narratorText.player.GetComponent<PlayerMovement>().enabled = true;
        }

        if (bossText.currentDisplayingText == 0 && bossText.itemInfoText.text == bossText.itemInfo[0])
        {
            bossText.currentDisplayingText = (bossText.currentDisplayingText + 1) % bossText.itemInfo.Length;
            bossText.Animate();
        }
        if (bossText.currentDisplayingText == 1 && bossText.itemInfoText.text == bossText.itemInfo[1])
        {
            bossText.currentDisplayingText = (bossText.currentDisplayingText + 1) % bossText.itemInfo.Length;
            bossText.Animate();
        }
        if (bossText.currentDisplayingText == 2 && bossText.itemInfoText.text == bossText.itemInfo[2])
        {
            bossText.textBox.SetActive(false);
            bossText.player.GetComponent<PlayerMovement>().enabled = true;
            bossText.boss.GetComponent<BossGoUp>().enabled = true;
        }
        if (bossText.currentDisplayingText == 3 && bossText.itemInfoText.text == bossText.itemInfo[3])
        {
            bossText.currentDisplayingText = (bossText.currentDisplayingText + 1) % bossText.itemInfo.Length;
            bossText.player.GetComponent<PlayerMovement>().enabled = false;
            bossText.Animate();
        }
        if (bossText.currentDisplayingText == 4 && bossText.itemInfoText.text == bossText.itemInfo[4])
        {
            bossText.currentDisplayingText = (bossText.currentDisplayingText + 1) % bossText.itemInfo.Length;
            bossText.Animate();
        }
        if (bossText.currentDisplayingText == 5 && bossText.itemInfoText.text == bossText.itemInfo[5])
        {
            bossText.textBox.SetActive(false);
            bossText.player.GetComponent<PlayerMovement>().enabled = true;
            bossText.boss.GetComponent<BossGoUp>().enabled = true;
            bossText.boss.SetActive(false);
            Destroy(bossText.door);
            bossDefeated = true;
        }

        if (levelOneEndText.currentDisplayingText == 0 && levelOneEndText.itemInfoText.text == levelOneEndText.itemInfo[0] && bossDefeated == true)
        {
            levelOneEndText.currentDisplayingText = (levelOneEndText.currentDisplayingText + 1) % levelOneEndText.itemInfo.Length;
            levelOneEndText.Animate();
        }
        if (levelOneEndText.currentDisplayingText == 1 && levelOneEndText.itemInfoText.text == levelOneEndText.itemInfo[1] && bossDefeated == true)
        {
            levelOneEndText.textBox.SetActive(false);
            levelOneEndText.player.GetComponent<PlayerMovement>().enabled = true;
        }
    }
}
