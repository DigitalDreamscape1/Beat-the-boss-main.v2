using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject LoginObj;
    public GameObject RegisterObj;

    public InputField usernameInput;
    public InputField passwordInput;
    public Button loginButton;
    public Button goToRegisterButton;

    ArrayList credentials;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(login);
        goToRegisterButton.onClick.AddListener(moveToRegister);

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            Debug.Log("Credential File doesn't exist");
        }
    }

    // Update is Called once per frame
    void login()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));

        foreach (var i in credentials)
        {
            string line = i.ToString();


            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(usernameInput.text) && i.ToString().Substring(i.ToString().IndexOf(":") + 1).Equals(passwordInput.text))
            {
                isExists = true;
                break;
            }
        }
        if (isExists)
        {
            Debug.Log($"Logging in '{usernameInput.text}'");
            loadWelcomeScreen();
        }
        else
        {
            Debug.Log("Incorrect credentials");
        }
    }

    void moveToRegister()
    {
        LoginObj.SetActive(false);
        RegisterObj.SetActive(true);

    }
    void loadWelcomeScreen()
    {
        SceneManager.LoadScene(1);
    }


}