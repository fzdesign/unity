using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text countdown;
    float timer = 15;
    public string SceneName;
   
    void Start()
    {
       
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log("timer"+timer);
        float timeleft = timer;
        Debug.Log("timeleft"+timeleft);
        countdown.text = Mathf.Round(timeleft).ToString() + " sec";

         if (timer<=0)
         {
            
            SceneManager.LoadScene("Ending2");
            Debug.Log("time is up");


         }
    }

   

}
