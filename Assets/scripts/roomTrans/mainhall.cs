using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainhall : MonoBehaviour
{
    public void onTriggerEnter(Collider col)
    {

        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        }

    }
}
