using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newswipe : MonoBehaviour
{

    private Vector2 startPos;
    private bool isSwiping = false;
    public float swipeThreshold = 50f; // Adjust this value according to your needs
    public GameObject button;
    public GameObject UiList;
    public RectTransform panelTransform; 
    public float speed = 1.0f;
    public Text emailcount;
    int email = 50;
 


    void Update()
    {
        


        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Detect touch start
            if (touch.phase == TouchPhase.Began)
            {
                startPos = touch.position;
                isSwiping = true;
            }

            // Detect touch end
            if (touch.phase == TouchPhase.Ended)
            {
                isSwiping = false;
                Vector2 endPos = touch.position;
                Vector2 swipeDirection = endPos - startPos;

                if (Mathf.Abs(swipeDirection.x) > swipeThreshold && swipeDirection.x < 0)
                {   
                    
                    Destroy(button);
                    float moveAmount = speed * Time.deltaTime;
                    panelTransform.anchoredPosition += new Vector2(0f, 200);
                    UiList.GetComponent<RectTransform>().anchoredPosition += new Vector2(0f,20);
                    email -= 1;
                    emailcount.text = email.ToString();
                    if (email == 0)
                    {

                        Debug.Log("win the game");
                    }

                }
            }
        }
    }
}
