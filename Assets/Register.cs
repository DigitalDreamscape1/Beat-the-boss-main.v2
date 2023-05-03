using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{

    public GameObject RegisterObj;
    public GameObject LoginObj;

    public InputField usernameInput;
    public InputField PasswordInput;
    public Button registerButton;
    public Button goToLoginButton;

    ArrayList credentials;

    // Start is called before the first frame update
    private void Start()
    {
        registerButton.onClick.AddListener(writeStuffToFile);
        goToLoginButton.onClick.AddListener(goToLoginScene);

        if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/credentials.txt", "");
        }
    }
    public void goToLoginScene()
    {
        RegisterObj.SetActive(false);
        LoginObj.SetActive(true);
    }

    void writeStuffToFile()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        foreach (var i in credentials)
        {
            if (i.ToString().Contains(usernameInput.text))
            {
                isExists = true;
                break;
            }
        }
        if (isExists)
        {
            Debug.Log($"Username '{usernameInput.text}' already exists");
        }
        else
        {
            credentials.Add(usernameInput.text + ":" + PasswordInput.text);
            File.WriteAllLines(Application.dataPath + "/credentials.txt", (string[])credentials.ToArray(typeof(string)));
            Debug.Log("Account Registered");
        }
    }

}
