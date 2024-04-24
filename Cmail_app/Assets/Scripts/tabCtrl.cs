using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabCtrl : MonoBehaviour
{
    public Text emailcount;

    int email = 100;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.touchCount >0)
        {   
           email -= 1;
            emailcount.text = email.ToString();
            if (email == 0)
            {
                
                //win the game
            }
        }

    }
}
