using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List <QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int CurrentQuestion;

    public Text QuestionTxt;

    public int trigger_counter = 0;

    public void Start()
    {
        trigger_counter++;
        if (trigger_counter != 1)
        {
            QnA.RemoveAt(CurrentQuestion);
        }
        generateQuestion();
    }

    public void Correct()
    {
        Debug.Log("Count: " + QnA.Count + "  | Current: " + CurrentQuestion);
        QnA.RemoveAt(CurrentQuestion);
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
        if (QnA.Count > 0)
        {
            CurrentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[CurrentQuestion].Question;
            SetAnswewrs();
        }
        else
        {
            Debug.Log("out of questions");
            SceneManager.LoadScene(1);
        }
        

       
    }
}
