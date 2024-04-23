using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabCtrl : MonoBehaviour
{
    public Text emailcount;

    int email = 999;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.touchCount >0)
        {   
           email -= 1;
            emailcount.text = email.ToString();
        }

    }
}
