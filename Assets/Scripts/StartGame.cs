using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Method to load the Next Scene
    public void LoadNextScene(string sceneName)
    {
        SceneManager.LoadScene("NextScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}