using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompRoom1 : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }
}
