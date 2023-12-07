using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credit : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exiting Game");
    }
}
