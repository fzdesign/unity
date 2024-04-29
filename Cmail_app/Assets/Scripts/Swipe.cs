using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Swipe : MonoBehaviour
{

    public Text countdown;
    float timer = 15;
    int timeleft;

    public GameObject email;
    public GameObject emailList;
    public Vector2 touchBegin;
    public Vector2 touchEnd;
   
    void Start()
    {
       
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        float timeleft = timer;
        countdown.text = Mathf.Round(timeleft).ToString() + " sec";

         if (timer - Time.deltaTime == 0)
         {
            timer = 0;
            loadScenebyName("Ending");
            Debug.Log("time is up");
         }
    }

    public void loadScenebyName(string sceneName)
    {
        SceneManager.LoadScene("Ending");
    }

}
