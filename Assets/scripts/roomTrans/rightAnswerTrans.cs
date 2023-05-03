using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rightAnswerTrans : MonoBehaviour
{
    public GameObject submitTrig;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightAnswer"))
        {
            SceneManager.LoadScene("mainHall");
        }
    }

}
