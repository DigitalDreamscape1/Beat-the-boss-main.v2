using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List <QuestionjAndAnswer> QnA;
    public GameObject[] options;
    public int CurrentQuestion;

    public Text QuestionTxt;


    public void Start()
    {
        QnA.RemoveAt(CurrentQuestion);
        generateQuestion();
    }

    public void Correct()
    {
        generateQuestion();
    }
    void SetAnswewrs()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[CurrentQuestion].Answers[i];

            if (QnA[CurrentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        CurrentQuestion = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[CurrentQuestion].Question;
        SetAnswewrs(); 

       
    }
}
