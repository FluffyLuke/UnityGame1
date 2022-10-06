using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private LevelDetails levelDetails;

    public Animator transition;

    

    public void Start()
    {
        FindObjectOfType<AudioManager>().PlayAudio(levelDetails.levelTheme);
    }
    public void ButtonAudio(string audioName)
    {
        FindObjectOfType<AudioManager>().PlayAudio(audioName);
    }

    public void LoadNextLevel(int levelIndex)
    {
        Debug.Log("Game is changing to the next level");
        StartCoroutine(LoadLevel(levelIndex));
        //SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Debug.Log("Game is closing itself");

        StartCoroutine(ExitGame());
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(levelDetails.levelTransitionTime);

        //Load scene
        SceneManager.LoadScene(levelIndex);
    }

    IEnumerator ExitGame()
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(levelDetails.levelTransitionTime);

        //Exit (Zmieniæ przy pe³nej grze)
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}
