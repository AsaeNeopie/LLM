using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartLevelF()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void NextScene1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void NextScene2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void NextScene3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void NextScene4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void NextScene5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void NextScene6()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
