using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_1 : MonoBehaviour
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
        if (CorrectAnswer1.activeSelf == false)
        {
            CorrectAnswer1.SetActive(true);
        }
        if (WrongAnswer1.activeSelf == true)
        {
            CorrectAnswer1.SetActive(false);
        }
        if (CorrectAnswer1.activeSelf == true || WrongAnswer1.activeSelf == true)
          {
            WrongAnswer2.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
