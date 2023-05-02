using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rightAnswerTrans : MonoBehaviour
{
    public GameObject submitTrig;
    public GameObject scoretrigger;

    private void OnTriggerEnter(Collider other)
    {
        
        //if (other.CompareTag("RightAnswer"))
       // {
         //   SceneManager.LoadScene("mainHall");
       // }
    }
    private void OntrigerEnter(Collider score)
    {
        csvSave addPoint;
        if (score.CompareTag("RightAnswer"))
        {
            addPoint = FindObjectOfType<csvSave>();
            addPoint.AddScore();
            Debug.Log("score + 1");
        }
    }
}
