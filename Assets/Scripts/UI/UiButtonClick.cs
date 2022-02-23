using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiButtonClick : MonoBehaviour
{

    public void ExitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
