using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveTextFade : MonoBehaviour
{
    public float fadeTime = 2f;
    private TextMeshProUGUI fadeAwayMessage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeAwayMessage = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeTime > 0)
        {
            fadeTime -= Time.deltaTime;
            fadeAwayMessage.color = new Color(fadeAwayMessage.color.r, fadeAwayMessage.color.g, fadeAwayMessage.color.b, fadeTime);
        }
    }
}
