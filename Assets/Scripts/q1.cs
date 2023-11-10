using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class q1 : MonoBehaviour
{
    public InputField name; // only compatible with lagacy inputfield ui object
    public Button submitButton;

    public void callQ1(){
        StartCoroutine("Q1");
    }

    IEnumerator Q1(){
        WWWForm form = new WWWForm();
        form.AddField ("name", name.text);
        // Debug.Log("name: "+name.text);
        // WWW www = new WWW("http://localhost/sqlconnect/q1.php", form);
        UnityWebRequest www = UnityWebRequest.Post("http://localhost:8889/sqlconnect/q1.php", form);
        // yield return www;
        yield return www.SendWebRequest();
        // if (www.text == "0"){ // everything working well
        //     Debug.Log("q1 submitted successfully");
        //     UnityEngine.SceneManagement.SceneManager.LoadScene(2); // move on to the next question
        // }else{
        //     Debug.Log("error #"+www.text);
        // }
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("success");
            Debug.Log(www.downloadHandler.text);
        }
    }
}
