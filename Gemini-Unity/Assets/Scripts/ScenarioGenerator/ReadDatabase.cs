using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ReadDatabase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string url = "https://xy30qatok2.execute-api.us-east-1.amazonaws.com/prod/waypoints";
        string API_CLIENT_ID = "gemini";
        string API_CLIENT_SECRET = "hs66Ra3J6IhnKQY80lCw9s36431coI0J";

        byte[] bytesToEncode = Encoding.UTF8.GetBytes(API_CLIENT_ID + ":" + API_CLIENT_SECRET);
        string encodedText = Convert.ToBase64String(bytesToEncode);

        StartCoroutine(GetRequest(url));
        IEnumerator GetRequest(string uri)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
            {
                webRequest.SetRequestHeader("Authorization", encodedText);
                yield return webRequest.SendWebRequest();

                string[] pages = uri.Split('/');
                int page = pages.Length - 1;

                if (webRequest.isNetworkError)
                {
                    Debug.Log(pages[page] + ": Error: " + webRequest.error);
                }
                else
                {
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
