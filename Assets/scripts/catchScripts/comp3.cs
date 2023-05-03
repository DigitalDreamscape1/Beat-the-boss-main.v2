using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comp3 : MonoBehaviour
{
    public TMP_InputField input;

    //public GameObject HUD;

    // Start is called before the first frame update
    private void Start()
    {
        input.onEndEdit.AddListener(Answer);
    }

    private void Answer(string arg2)
    {

        if (arg2.ToLower() == "exploitation")
        {
            //HUD.GetComponent<pointsController>().ScoreUp();
            SceneManager.LoadScene(1);
            Debug.Log("correct");
        }

        Debug.Log(arg2);
    }
}
