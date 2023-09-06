using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Collections;


public class signup_script : MonoBehaviour
{
    public InputField EmailField;
    public InputField PassField;
    public Button submit_Button;
    public Button agree_Button;
    public Dropdown MyDropDown;
    public Toggle t;
    string sex;
   
   private void Awake(){
        NativeLeakDetection.Mode = NativeLeakDetectionMode.EnabledWithStackTrace;
    }
    
    void Start(){
        t = GetComponent<Toggle>();
    }
    void Update()
    {

        
    }

    public void CallSignUP(){
        StartCoroutine(Register());
    }

    IEnumerator Register(){
        WWWForm form = new WWWForm();
        form.AddField("name",EmailField.text);
        form.AddField("password",PassField.text);
        form.AddField("sex",sex);
        using WWW www = new WWW("http://localhost/SQL/sqlconnect/register.php",form);
        yield return www;

        if(www.text =="0"){
            Debug.Log("User created successfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else{
            Debug.Log("User creation failed. Error #" + www.text);
        }
        
    }


    public void DropDownSelectionChanged()
    {
        
        Debug.Log(MyDropDown.value + sex);
        if(MyDropDown.value == 1){
            sex ="M";
        }  
            
        if(MyDropDown.value == 2){
            sex = "W";
        } 
            
    }

   public void ToggleOnValueChanged_(bool isOn)
    {
        if (isOn)
        {
            agree_Button.interactable = true;
            Debug.Log("AGREE");
        }
        else
        {
            agree_Button.interactable = false;
            Debug.Log("NotAGREE");
        }
    }


    public void VerifyInputs(){
        submit_Button.interactable = ( EmailField.text.Length >= 8 && PassField.text.Length >=8 );
    }
}
