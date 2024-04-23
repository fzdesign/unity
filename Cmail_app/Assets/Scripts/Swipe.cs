using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{

    public Text countdown;
    float timer = 30;
    float timeleft;

    void Start()
    {
        
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        countdown.text = timer.ToString();

       // if (timer - Time.deltaTime == 0)
       // {
        //    Application.Quit();
        //}
    }
}
