using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    static public void LoadWinScene()
    {
        SceneManager.LoadScene(3);
    }
    static public void LoadLoseScene()
    {
        SceneManager.LoadScene(4);
    }
    static public void LoadStartScene()
    {
        SceneManager.LoadScene(1);
    }

}
