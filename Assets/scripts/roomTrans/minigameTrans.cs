using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class minigameTrans : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("miniGame2");
    }
}
