using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public Color startColor;

    private void Start()
    {
        quizManager = GameObject.FindGameObjectWithTag("QuizManager").GetComponent<QuizManager>();
    }

    public void Answer()
    {
        if (isCorrect)
        {
            
            Debug.Log("Correct Answer");
            quizManager.Correct();

        }
        else
        {
            
            Debug.Log("Wrong Answer");
            quizManager.Correct();

        }
    }
}
