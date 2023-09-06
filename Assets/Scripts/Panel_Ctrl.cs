using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panel_Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject checkPanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNamePanel(){
        checkPanel.SetActive(true);
        Debug.Log("Open");

    }
    public void closeNamePanel(){
            checkPanel.SetActive(false);
            Debug.Log("Colse");
        }


}

