using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGameText : MonoBehaviour
{
    public float fadeTime = 0.7f;
    public ScoreManager scoreManager;
    private TextMeshProUGUI fadeAwayMessage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeAwayMessage = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeTime > 0 && scoreManager.currentScore >= scoreManager.goalScore)
        {
            fadeAwayMessage.enabled = true;
            fadeTime -= Time.deltaTime;
            fadeAwayMessage.color = new Color(fadeAwayMessage.color.r, fadeAwayMessage.color.g, fadeAwayMessage.color.b, fadeTime);
        }
        else
        {
            fadeAwayMessage.enabled = false;
        }
    }
}
