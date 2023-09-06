<?php

$con = mysqli_connect('localhost', 'root','','unityacess');

    //check connect
    if(mysqli_connect_errno()){
        echo "1: Connection fail"; //ERROR
        exit();
    }

    $username = $_POST["name"];
    $password = $_POST["password"];
    //$sex = $_POST["sex"];

    //check
    $namecheckquery = "SELECT username , salt, hash, sex FROM players WHERE username='" . $username . "';";

    $namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check fail");
    if(mysqli_num_rows($namecheck) != 1){
        echo "5: Either no user with name,or more than one";
        exit();
    }

    //get login info
    $existinginfo = mysqli_fetch_assoc($namecheck);
    $salt = $existinginfo["salt"];
    $hash = $existinginfo["hash"];

    $loginhash = crypt($password,$salt);
    if ($hash != $loginhash){
        echo "6: Incorrect password"; 
        exit();
    }

    echo('0');

?>