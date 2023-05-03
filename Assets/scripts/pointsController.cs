using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsController : MonoBehaviour
{
    private int playerScore = 0;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = playerScore.ToString();
    }

    public void ScoreUp()
    {
        playerScore += 1;
        score.text = playerScore.ToString();
    }
}
