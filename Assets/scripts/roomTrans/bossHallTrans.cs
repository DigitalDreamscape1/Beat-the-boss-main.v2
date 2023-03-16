using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossHallTrans : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("bossHall");
    }
}
