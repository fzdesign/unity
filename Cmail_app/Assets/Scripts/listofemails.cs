using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class listofemails : MonoBehaviour
{
    public RectTransform prefab; 
    public ScrollRect scrollView; 
    public RectTransform contentPanel; 
    public int itemsCount = 50; 
    private bool isLoadingMoreItems = false; 
    public float threshold = 100f; 
    private int totalItems = 0;
    private Vector2 startPos;
    private bool isSwiping = false;
    public float swipeThreshold = 50f;
    public GameObject button;
    public GameObject UiList;
    public RectTransform panelTransform;
    public float speed = 1.0f;
    public Text emailcount;
    int email;
    public AudioClip swipeSound;
    private AudioSource audioSource;
    public string SceneName;



    void Start()
    {
        LoadItems(itemsCount);

    }

    void Update()
    {
        if (ShouldLoadMoreItems())
        {
            LoadItems(itemsCount);
        }

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

                    DestroyFirstChild();
                    float moveAmount = speed * Time.deltaTime;
                    //panelTransform.anchoredPosition += new Vector2(0f, 300);
                    UiList.GetComponent<RectTransform>().anchoredPosition += new Vector2(0f, 100);
                    //email -= 1;
                    emailcount.text = email.ToString();
                    if (email == 0)
                    {
                        SceneManager.LoadScene("Ending");
                        Debug.Log("win the game");
                    }

                }
            }
        }
    }

    private void DestroyFirstChild()
    {
        if (UiList.transform.childCount > 0)
        {
            Destroy(UiList.transform.GetChild(0).gameObject);
            audioSource.Play();
        }
    }



    private bool ShouldLoadMoreItems()
    {
        return !isLoadingMoreItems &&
               scrollView.normalizedPosition.y < 0.1f; 
    }

    private void LoadItems(int count)
    {
        isLoadingMoreItems = true;
        for (int i = 0; i < count; i++)
        {
            var instance = Instantiate(prefab.gameObject) as GameObject;
            instance.transform.SetParent(contentPanel, false);
            instance.transform.localScale = Vector3.one;
            instance.GetComponentInChildren<Text>().text = "Item " + (totalItems + i); 
        }
        totalItems += count;
        isLoadingMoreItems = false;
    }
}
