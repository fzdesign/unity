using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{

    public Text countdown;
    float timer = 30;
    int timeleft;

    public GameObject email;
    public GameObject emailList;
    public Vector2 touchBegin;
    public Vector2 touchEnd;
    public GameObject endText;

    void Start()
    {
        //swipte the upper layer but it has to be detected that it is on the button instead of anywhere of the screen.


        //the green part reveals as the button is swiped


        //the button is dissapeared


        //the entire scroll moves up

        endText.SetActive(false);
        
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        float timeleft = timer;
        countdown.text = Mathf.Round(timeleft).ToString() + " sec";

        // if (timer - Time.deltaTime == 0)
        // {
        //    Application.Quit();
        //      endText.SetActive(false);
        //}
    }


    void swipeUI()
    {


    }
}
