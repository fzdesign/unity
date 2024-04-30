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
        float timeleft = timer;
        countdown.text = Mathf.Round(timeleft).ToString() + " sec";

         if (timeleft  == 0)
         {
            
            SceneManager.LoadScene("Ending");
            Debug.Log("time is up");

         }
    }

   

}
