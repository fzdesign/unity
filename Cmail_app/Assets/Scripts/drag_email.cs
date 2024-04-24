using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class drag_email : MonoBehaviour
{
    bool hoveringTag = false;
    Vector2 startpos;
    Vector2 buttonStarpos;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.touchCount <= 0) return;
        Touch curTouch = Input.GetTouch(0);
        RectTransform myRectTransform = GetComponent<RectTransform>();
        Debug.Log(Input.mousePosition);

        if (hoveringTag)
        {
            myRectTransform.anchoredPosition = new Vector3(buttonStarpos.x + (curTouch.position.x - startpos.x), myRectTransform.anchoredPosition.y);
            
        }

        if (curTouch.phase == TouchPhase.Ended && hoveringTag)
        { 
            hoveringTag = false;
            myRectTransform.anchoredPosition = buttonStarpos;
        }

        if (myRectTransform.anchoredPosition.x <= 0)
        {
            Destroy(gameObject);

        }
    }

    public void OnPress()
    {
        hoveringTag = true;
        startpos = Input.GetTouch(0).position;
        buttonStarpos = GetComponent<RectTransform>().anchoredPosition;
        Debug.Log(buttonStarpos);
    }
}
