using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public string sInput;
    public void CheckUsername(string s)
    {
        sInput = s;
        Debug.Log(s);
        Debug.Log(sInput);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
