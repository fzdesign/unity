using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{

    public Text countdown;
    float timer = 30;
    int timeleft;

    void Start()
    {
        //swipte the upper layer


        //the green part reveals as the button is swiped


        //the button is dissapeared


        //the entire scroll moves up
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        //timeleft = Mathf.Round(timer);
        countdown.text = timeleft.ToString();

       // if (timer - Time.deltaTime == 0)
       // {
        //    Application.Quit();
        //}
    }
}
