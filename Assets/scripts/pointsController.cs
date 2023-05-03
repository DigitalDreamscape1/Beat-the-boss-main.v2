using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System;

public class pointsController : MonoBehaviour
{
    private int playerScore = 0;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        string sScore;
        using (StreamReader readtext = new StreamReader("score.txt"))
        {
            sScore = readtext.ReadLine();
        }
        
        playerScore = Convert.ToInt32(sScore);
        score.text = playerScore.ToString();
        
    }

    public void ScoreUp()
    {

        playerScore += 1;
        score.text = playerScore.ToString();
        using (StreamWriter writetext = new StreamWriter("score.txt"))
        {
            writetext.WriteLine(playerScore);
        }
    }

    public void ResetScore()
    {
        playerScore = 0;
        score.text = playerScore.ToString();
        using (StreamWriter writetext = new StreamWriter("score.txt"))
        {
            writetext.WriteLine(playerScore);
        }
    }
}
