using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Webtest : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        using WWW request = new WWW("http://localhost/SQL/sqlconnect/webtest.php");
        yield return request;
        string[] webResults = request.text.Split('\t');
        Debug.Log(webResults[0]);
        int webNumber = int.Parse(webResults[1]);
        webNumber *=2;
        Debug.Log(webNumber);
        
    }

}
