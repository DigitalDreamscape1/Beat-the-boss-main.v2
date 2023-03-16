using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossRoomTrans : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("bossRoom");
    }
}
