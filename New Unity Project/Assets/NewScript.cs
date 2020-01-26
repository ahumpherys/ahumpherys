using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    int myInt = 5;
    void Start()
    {
        // partially coding along C# variables and functions video on canvas
        myInt = multiplyByTwo(myInt);
      Debug.Log(myInt);
      print("The myInt variable is changed from 5 to");
      print(myInt);
      print("code is complex");
      //adding some comments
      //because I don't have enough lines of code
    }
    int multiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}