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
        SceneManager.LoadScene("Level1");
    }

    public void NextScene2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void NextScene3()
    {
        SceneManager.LoadScene("Level3 1");
    }

    public void NextScene4()
    {
        SceneManager.LoadScene("/Assets/Scenes/Level4");
    }

    public void NextScen4A()
    {
        SceneManager.LoadScene("Level4A");
    }

    public void NextScene5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void NextScen5A()
    {
        SceneManager.LoadScene("Level5A");
    }
    public void NextScene6()
    {
        SceneManager.LoadScene("Level6");
    }
    public void EndScene()
    {
        SceneManager.LoadScene("Victory");
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
