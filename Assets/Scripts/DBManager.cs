using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class DBManager
{
    
    public static string username;
    public static string sex;
    //public static string sex;
    public static bool LoggedIn { get  { return username != null; } }

    public static void LogOut(){
        username = null;
    }
}
