using JetBrains.Annotations;
using System.Collections;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Boss Level 1");
    }
}
