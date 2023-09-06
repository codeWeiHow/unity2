<?php

    $con = mysqli_connect('localhost', 'root','','unityacess');

    //check connect
    if(mysqli_connect_errno()){
        echo "1: Connection fail"; //ERROR
        exit();
    }

    $username = $_POST["name"];
    $password = $_POST["password"];
    $sex = $_POST["sex"];

    //check
    $namecheckquery = "SELECT username FROM players WHERE username='" . $username . "';";

    $namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check fail");

    if(mysqli_num_rows($namecheck) > 0){
        echo "3: Name already exists";
        exit();
    }

    //add user to table
    $salt = "\$5\$rounds=5000\$" . "steamedhams" . $username . "\$";
    $hash = crypt($password,$salt);
    $insertuserquery = "INSERT INTO players (username, hash, salt, sex) VALUES ('" . $username . "', '" . $hash . "','" . $salt . "', '" . $sex . "');";
    mysqli_query($con, $insertuserquery) or die("4: Insert player fail");

    echo("0");

?>