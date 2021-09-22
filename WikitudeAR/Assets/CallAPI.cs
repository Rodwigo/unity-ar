using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net;
using System.IO;

public class CallAPI : MonoBehaviour
{
    public TextMeshProUGUI user;
    string url = "https://api-totalpower.herokuapp.com/";
    public string usuario;

    // Start is called before the first frame update
    void Start()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api-totalpower.herokuapp.com/");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();

        print("JSON response: " + json);

        string[] splitArray = json.Split(char.Parse(":"));
        user.text = splitArray[1];
    }
}
