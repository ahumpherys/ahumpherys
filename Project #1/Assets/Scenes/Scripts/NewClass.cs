using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    public string stringName;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    void Start()
    {
        print(stringName);
        print(intNum);
        print(floatNum);
        print(gameObj);
    }

    void Update()
    {
        
    }
}
