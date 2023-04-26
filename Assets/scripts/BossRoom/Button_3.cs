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
        Debug.Log("button 1 pressed");
        if (WrongAnswer1.activeSelf == false)
        {
            WrongAnswer1.SetActive(true);
        }
        if (CorrectAnswer1.activeSelf == true)
        {
            WrongAnswer1.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
