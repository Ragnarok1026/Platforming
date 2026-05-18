using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class SkipBoss3 : MonoBehaviour
{
    public ShadowHealth health;
    public GameObject Shadow;
    public GameObject Door;
    public GameObject Hover;
    public GameObject Fight;
    public GameObject cutsceneTrigger;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnSkip()
    {
        if (health.currentDisplayingText == 0 && health.itemInfoText.text == health.itemInfo[0] && health.isDead == false)
        {
            health.currentDisplayingText = (health.currentDisplayingText + 1) % health.itemInfo.Length;
            health.Animate();
        }
        if (health.currentDisplayingText == 1 && health.itemInfoText.text == health.itemInfo[1] && health.isDead == false)
        {
            health.textBox.SetActive(false);
            health.player.GetComponent<PlayerMovement>().enabled = true;
            Destroy(cutsceneTrigger);
        }
        if (health.currentDisplayingText == 2 && health.itemInfoText.text == health.itemInfo[2] && health.isDead == true)
        {
            health.currentDisplayingText = (health.currentDisplayingText + 1) % health.itemInfo.Length;
            health.textBox.SetActive(false);
            Destroy(Shadow);
            Destroy(Door);
            Destroy(Hover);
            Destroy(Fight);
            Destroy(cutsceneTrigger);
        }
    }
}
