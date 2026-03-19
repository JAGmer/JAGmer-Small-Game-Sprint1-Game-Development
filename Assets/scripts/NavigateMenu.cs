using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.5f;

    public void LoadNextScene(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    public void exit()
    {
        Debug.Log("Game has been quit");
        Application.Quit();
    }
}
