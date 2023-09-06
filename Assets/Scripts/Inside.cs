using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Collections;

public class Inside : MonoBehaviour
{
    public Text playerDisplay;
    public Image ManPic;//拖入图片
    public Slider slider;
    public Slider slider2;
    public Slider slider3;
    
    private void Awake(){
        NativeLeakDetection.Mode = NativeLeakDetectionMode.EnabledWithStackTrace;
    }

    private void Start()
    {
        if (DBManager.LoggedIn){
            playerDisplay.text = "Hello! " + DBManager.username;
        }
        slider = GetComponent<Slider>();
        slider2 = GetComponent<Slider>();
        slider3 = GetComponent<Slider>();
        ManPic.color=new Color(255/255f,255/255f,255/255,255/255f);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSliderValueChanged(){
        
        //ManPic.color=new Color(var1/255f,var1/255f,var1/255,255/255f);
    }
}

