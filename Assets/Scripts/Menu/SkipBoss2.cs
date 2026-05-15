using UnityEngine;

public class SkipBoss2 : MonoBehaviour
{
    public StartBossCutscene cutscene;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnSkip()
    {
        if (cutscene.currentDisplayingText == 0 && cutscene.itemInfoText.text == cutscene.itemInfo[0])
        {
            cutscene.currentDisplayingText = (cutscene.currentDisplayingText + 1) % cutscene.itemInfo.Length;
            cutscene.Animate();
        }
        if (cutscene.currentDisplayingText == 1 && cutscene.itemInfoText.text == cutscene.itemInfo[1])
        {
            cutscene.currentDisplayingText = (cutscene.currentDisplayingText + 1) % cutscene.itemInfo.Length;
            cutscene.Animate();
        }
        if (cutscene.currentDisplayingText == 2 && cutscene.itemInfoText.text == cutscene.itemInfo[2])
        {
            cutscene.endCutscene = true;
            cutscene.textBox.SetActive(false);
            cutscene.bossTeleport.SetActive(true);
            Invoke("TeleportBossOut", 0.1f);
            cutscene.player.GetComponent<PlayerMovement>().enabled = true;
        }
        if (cutscene.currentDisplayingText == 3 && cutscene.itemInfoText.text == cutscene.itemInfo[3] && cutscene.endCutscene == true)
        {
            cutscene.currentDisplayingText = (cutscene.currentDisplayingText + 1) % cutscene.itemInfo.Length;
            cutscene.player.GetComponent<PlayerMovement>().enabled = false;
            cutscene.player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            cutscene.Animate();
        }
        if (cutscene.currentDisplayingText == 4 && cutscene.itemInfoText.text == cutscene.itemInfo[4])
        {
            cutscene.currentDisplayingText = (cutscene.currentDisplayingText + 1) % cutscene.itemInfo.Length;
            cutscene.Animate();
        }
        if (cutscene.currentDisplayingText == 5 && cutscene.itemInfoText.text == cutscene.itemInfo[5])
        {
            cutscene.textBox.SetActive(false);
            cutscene.bossTeleport.SetActive(true);
            cutscene.bossDoor.SetActive(false);
            cutscene.player.GetComponent<PlayerMovement>().enabled = true;
            Invoke("TeleportBossOut", 0.1f);
        }
    }
}
