using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void AnimTestButton()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
