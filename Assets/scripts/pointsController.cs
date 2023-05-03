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
    public void saveScoreTooCSV()
    {
        bool Error = false;
        //Opens "savedata.csv" and counts the number of rows in the file.
        int rows = 0;
        string line;
        try
        {
            System.IO.StreamReader file = new System.IO.StreamReader("saveData.csv");
            while ((line = file.ReadLine()) != null)
            {
                rows++;
            }
            file.Close();
            //exsta row is added for new booking
            rows += 1;
        }
        catch (Exception ex)
        // If an error occurs an error message will show and error will be set to true
        {
            Dedug.Log("file error ");
            Error = true;
        }

        //Arrys are declard and size of arrys are set 
        string[] username = new string[rows];
        string[] score = new string[rows];


        int iCounter = 0;

        if (Error == false)
        {
            try
            {
                var path = "saveData.csv";
                using (StreamReader sr = new StreamReader(path))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        username[iCounter] = headers[0];
                        score[iCounter] = headers[1];

                    }
                    while (!sr.EndOfStream)
                    {
                        iCounter++;
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = sr.ReadLine().Split(',');
                        username[iCounter] = fields[0];
                        score[iCounter] = fields[1];

                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.Log("file error read");
                Error = true;
            }

        }
        foreach (var item in username)
        {
            Console.WriteLine(item);
        }
        foreach (var item in score)
        {
            Console.WriteLine(item);
        }

        if (Error == false)
        {
            iCounter += 1;
            //Console.WriteLine("enter username");
            //username[iCounter] = Console.ReadLine();
            score[iCounter] = playerScore;
            //the file is deleted

            try
            {
                File.Delete("saveData.csv");
            }
            catch (Exception ex)
            {
                Dubug.Log("file error delete");
                Error = true;
            }
        }

        if (Error == false)
        {
            try
            {
                //new file is created 
                using (var stream = File.CreateText("saveData.csv"))
                {
                    //each line in the arrys are writen to the file
                    for (int iSaveCounter = 0; iSaveCounter != iCounter + 1; iSaveCounter++)
                    {
                        stream.WriteLine(username[iSaveCounter] + "," + score[iSaveCounter]);
                    }
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.Log("file error save");
                Error = true;
            }
        }
    }
}
