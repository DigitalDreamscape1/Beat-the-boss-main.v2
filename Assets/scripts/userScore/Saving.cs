using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Networking;

public class Saving : MonoBehaviour
{
    public Text ScoreTxt, userNameTxt;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void Save()
    {

        string str = userNameTxt.text + ", " + ScoreTxt.ToString();
        System.Text.UnicodeEncoding encode = new System.Text.UnicodeEncoding();
        byte[] bytes = encode.GetBytes(str);
        
        Debug.Log(str);

        if(!File.Exists(Application.dataPath + @"\Username.txt"))
        {
            FileStream file = null;
            file = new FileStream(Application.dataPath + @"\Username.txt", FileMode.Create);
            file.Write(bytes, 0, bytes.Length);
            file.Close();
        }
        else
        {
            using(StreamWriter write = File.AppendText(Application.dataPath + @"\Username.txt"))
            {
                write.WriteLine(str);
            }
        }


    }

}
