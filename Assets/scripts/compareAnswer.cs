using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


[RequireComponent(typeof(InputField))]
public class compareAnswer : MonoBehaviour
{
    public TMP_InputField input;

    //public GameObject HUD;

    // Start is called before the first frame update
    private void Start()
    {
        input.onEndEdit.AddListener(Answer);
    }

    private void Answer(string arg0)
    {

        if(arg0.ToLower() == "test")
        {
            //HUD.GetComponent<pointsController>().ScoreUp();
            SceneManager.LoadScene(1);
            Debug.Log("correct");
        }

        Debug.Log(arg0);
    }
}
