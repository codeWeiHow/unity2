using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Collections;

public class mian_script : MonoBehaviour
{
    public InputField EmailField;
    public InputField PassField;
    public Button submit_Button;

    private void Awake(){
        NativeLeakDetection.Mode = NativeLeakDetectionMode.EnabledWithStackTrace;
    }
    private void Start()
    {
        
        
    }

    void Update()
    {
        
    }

    public void GoSignUP(){
        SceneManager.LoadScene(1);
    }

    public void CallLogin(){
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer(){
        WWWForm form = new WWWForm();
        form.AddField("name",EmailField.text);
        form.AddField("password",PassField.text);
        using WWW www = new WWW("http://localhost/SQL/sqlconnect/login.php",form);
        yield return www;
        if(www.text[0] == '0'){
            DBManager.username = EmailField.text;
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        else{
            Debug.Log("Login Fail. Error #"+ www.text);
        }    
    }


    public void VerifyInputs(){
        submit_Button.interactable = (EmailField.text.Length >= 8 && PassField.text.Length >=8);
    }
}
