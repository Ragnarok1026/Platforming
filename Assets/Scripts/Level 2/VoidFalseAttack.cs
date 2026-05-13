using TMPro;
using UnityEngine;
using System.Collections;

public class VoidFalseAttack : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;
    public GameObject textBox;
    public GameObject player;
    public GameObject Void;
    public GameObject VoidTeleport;
    public ParticleSystem voidWall;
    public ParticleSystem voidAttack;
    public GameObject movePoint;
    public Animator animator;
    public bool voidIsHere = false;
    void Start()
    {
        voidWall.Stop();
        voidAttack.Stop();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) && textBox.activeSelf)
        {
            if (currentDisplayingText == 0 && itemInfoText.text == itemInfo[0])
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                textBox.SetActive(false);
                voidWall.Play();
                Invoke("VoidEnters", 0.5f);
            }
            if (currentDisplayingText == 1 && itemInfoText.text == itemInfo[1] && voidIsHere == true)
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                textBox.SetActive(true);
                Animate();
            }
            if(currentDisplayingText == 2 && itemInfoText.text == itemInfo[2])
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                Animate();
            }
            if (currentDisplayingText == 3 && itemInfoText.text == itemInfo[3])
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                Animate();
            }
            if (currentDisplayingText == 4 && itemInfoText.text == itemInfo[4])
            {
                textBox.SetActive(false);
                voidWall.Stop();
                voidAttack.Play();
                player.SetActive(false);
                Invoke("FadeToBlack", 1f);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            VoidAppears();
        }
    }
    public void VoidAppears()
    {
        Animate();
        Debug.Log("Animate");
    }
    public void VoidEnters()
    {
        Void.SetActive(true);
        Invoke("TeleportIn", 0.1f);
    }
    public void TeleportIn()
    {
        VoidTeleport.SetActive(false);
        voidIsHere = true;
        Invoke("Animate", 1);
    }
    public void FadeToBlack()
    {
        animator.SetBool("fadeToBlack", true);
        Invoke("NextScene", 1.50f);
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
