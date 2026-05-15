using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class ShadowHealth : MonoBehaviour
{
    [Header("Text Settings")]
    [SerializeField][TextArea] private string[] itemInfo;
    [SerializeField] private float textSpeed = 0.01f;

    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI itemInfoText;
    public int currentDisplayingText = 0;

    private StartShadow startShadowScript;

    public int maxHealth = 3;
    public int currentHealth;
    public bool isDead = false;
    public Animator animator;
    public float bounce;
    public Rigidbody2D rb;
    public GameObject Shadow;
    public GameObject player;
    public GameObject particle;
    public GameObject Door;
    public GameObject Hover;
    public GameObject Fight;
    public GameObject textBox;
    public GameObject cutsceneTrigger;
    void Start()
    {
        currentHealth = maxHealth;
        startShadowScript = GameObject.Find("HoverPoint").GetComponent<StartShadow>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) && textBox.activeSelf)
        {
            if (currentDisplayingText == 0 && itemInfoText.text == itemInfo[0] && isDead == false)
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                Animate();
            }
            if (currentDisplayingText == 1 && itemInfoText.text == itemInfo[1] && isDead == false)
            {
                textBox.SetActive(false);
                player.GetComponent<PlayerMovement>().enabled = true;
                Destroy(cutsceneTrigger);
            }
            if (currentDisplayingText == 2 && itemInfoText.text == itemInfo[2] && isDead == true)
            {
                currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
                textBox.SetActive(false);
                Destroy(Shadow);
                Destroy(Door);
                Destroy(Hover);
                Destroy(Fight);
                Destroy(cutsceneTrigger);
            }
        }
        if (currentHealth <= 0 && isDead == false)
        {
            currentDisplayingText = (currentDisplayingText + 1) % itemInfo.Length;
            isDead = true;
            textBox.SetActive(true);
            Invoke("ShowText", 0f);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            animator.SetTrigger("Hurt");
            animator.SetBool("isDead", true);
            startShadowScript.enabled = true;
            
            Die();
        }
    }
    void Die()
    {
        
    }
    public void ShowText()
    {
        Animate();
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
