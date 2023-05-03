using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_3 : MonoBehaviour
{
    public GameObject CorrectAnswer1;
    public GameObject CorrectAnswer2;
    public GameObject CorrectAnswer3;
    public GameObject CorrectAnswer4;

    public GameObject WrongAnswer1;
    public GameObject WrongAnswer2;
    public GameObject WrongAnswer3;
    public GameObject WrongAnswer4;
    public void OnMouseDown()
    {
        Debug.Log("button 3 pressed");
        if (WrongAnswer1.activeSelf == false)
        {
            WrongAnswer1.SetActive(true);
        }
        if (CorrectAnswer1.activeSelf == true)
        {
            WrongAnswer1.SetActive(false);
        }


        if (CorrectAnswer1.activeSelf == true || WrongAnswer1.activeSelf == true)
        {
            CorrectAnswer2.SetActive(true);
        }
        if (WrongAnswer2.activeSelf == true)
        {
            CorrectAnswer2.SetActive(false);
        }

        if (CorrectAnswer2.activeSelf == true || WrongAnswer2.activeSelf == true)
        {
            WrongAnswer3.SetActive(true);
        }
        if (CorrectAnswer3.activeSelf == true)
        {
            WrongAnswer3.SetActive(false);
        }


        if (CorrectAnswer3.activeSelf == true || WrongAnswer3.activeSelf == true)
        {
            WrongAnswer4.SetActive(true);
        }
        if (CorrectAnswer4.activeSelf == true)
        {
            WrongAnswer4.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
