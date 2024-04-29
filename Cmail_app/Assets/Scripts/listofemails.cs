using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listofemails : MonoBehaviour
{
    public RectTransform prefab; 
    public ScrollRect scrollView; 
    public RectTransform contentPanel; 
    public int itemsCount = 50; 
    private bool isLoadingMoreItems = false; 
    public float threshold = 100f; 
    private int totalItems = 0; 
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
