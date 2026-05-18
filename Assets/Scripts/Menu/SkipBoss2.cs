using Unity.VisualScripting;
using UnityEngine;

public class SkipBoss2 : MonoBehaviour
{
    public StartBossCutscene cutscene;
    public VoidFalseAttack voidCutscene;
    public GameObject bossDoor;
    public GameObject boss;
    public GameObject Void;
    public EnergyLeft health;
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
            if(cutscene.bossTeleport != null)
            {
                cutscene.bossTeleport.SetActive(true);
            }
            bossDoor.SetActive(false);
            cutscene.player.GetComponent<PlayerMovement>().enabled = true;
            if (boss != null)
                Destroy(boss);
            if (health != null)
                Destroy(health.gameObject);
        }

        if (voidCutscene.currentDisplayingText == 0 && voidCutscene.itemInfoText.text == voidCutscene.itemInfo[0])
        {
            voidCutscene.currentDisplayingText = (voidCutscene.currentDisplayingText + 1) % voidCutscene.itemInfo.Length;
            voidCutscene.textBox.SetActive(false);
            voidCutscene.voidWall.Play();
            voidCutscene.Invoke("VoidEnters", 0.5f);
        }
        if (voidCutscene.currentDisplayingText == 1 && voidCutscene.itemInfoText.text == voidCutscene.itemInfo[1] && voidCutscene.voidIsHere == true)
        {
            voidCutscene.currentDisplayingText = (voidCutscene.currentDisplayingText + 1) % voidCutscene.itemInfo.Length;
            voidCutscene.textBox.SetActive(true);
            voidCutscene.Animate();
        }
        if (voidCutscene.currentDisplayingText == 2 && voidCutscene.itemInfoText.text == voidCutscene.itemInfo[2])
        {
            voidCutscene.currentDisplayingText = (voidCutscene.currentDisplayingText + 1) % voidCutscene.itemInfo.Length;
            voidCutscene.Animate();
        }
        if (voidCutscene.currentDisplayingText == 3 && voidCutscene.itemInfoText.text == voidCutscene.itemInfo[3])
        {
            voidCutscene.currentDisplayingText = (voidCutscene.currentDisplayingText + 1) % voidCutscene.itemInfo.Length;
            voidCutscene.Animate();
        }
        if (voidCutscene.currentDisplayingText == 4 && voidCutscene.itemInfoText.text == voidCutscene.itemInfo[4])
        {
            voidCutscene.textBox.SetActive(false);
            voidCutscene.voidWall.Stop();
            voidCutscene.voidAttack.Play();
            voidCutscene.player.SetActive(false);
            voidCutscene.Invoke("FadeToBlack", 1f);
        }
    }
}
