using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Animator transition;
    public float transitionTime = 1f;
    private TextMeshProUGUI fadeAwayMessage;

    void Start()
    {
        fadeAwayMessage = GetComponentInChildren<TextMeshProUGUI>();
        Debug.Log("fadeAwayMessage is: " + fadeAwayMessage);
        fadeAwayMessage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreManager.currentScore >= scoreManager.goalScore)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        }
        else
        {
            transitionTime = 2.1f;
            fadeAwayMessage.enabled = true;
            fadeAwayMessage.text = "You finished the game.";
            StartCoroutine(LoadLevel(0));
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
