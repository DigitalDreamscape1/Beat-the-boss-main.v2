using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_2 : MonoBehaviour
{
    public GameObject WrongAnswer1;
    public GameObject WrongAnswer2;
    public GameObject WrongAnswer3;
    public GameObject WrongAnswer4;

    public GameObject CorrectAnswer1;    
    public GameObject CorrectAnswer2;
    public GameObject CorrectAnswer3;
    public GameObject CorrectAnswer4;
    public void OnMouseDown()
    {
        Debug.Log("button 1 pressed");
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
            WrongAnswer2.SetActive(true);
        }
        if (CorrectAnswer2.activeSelf == true)
        {
            WrongAnswer2.SetActive(false);
        }


        if (CorrectAnswer2.activeSelf == true || WrongAnswer2.activeSelf == true)
        {
            CorrectAnswer3.SetActive(true);
        }
        if (WrongAnswer3.activeSelf == true)
        {
            CorrectAnswer3.SetActive(false);
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
