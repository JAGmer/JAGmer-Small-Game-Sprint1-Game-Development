using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;
    public int goalScore;
    public TextMeshProUGUI txtCount;

    [SerializeField]
    public AudioClip collectSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentScore = 0;
        SetCountText("Count: " + currentScore.ToString());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            currentScore++;
            other.gameObject.SetActive(false);
            SoundEffectsManager.instance.PlaySoundEffect(collectSound, transform, 1f);
            Debug.Log("Score: " + currentScore + "out of" + goalScore);
            SetCountText("Count: " + currentScore.ToString());

            if (currentScore >= goalScore)
            {
                Debug.Log("You Won!");
                SetCountText("You Won!");
            }
        }
    }

    void SetCountText(string message)
    {
        txtCount.text = message;
    }
}