using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    
    void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum);
        print(gameObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
