using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class BossText : MonoBehaviour
{
    public GameObject boss;
    public TextMeshProUGUI textDisplay;
    public string[] cutscene1Lines;
    private int index = 0;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchText();
        }
    }
    void SwitchText()
    {
        if (cutscene1Lines.Length == 0) return;

        // Cycle through the array of strings
        index = (index + 1) % cutscene1Lines.Length;
        textDisplay.text = cutscene1Lines[index];
    }
}
