using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class swipeBehavior : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    private Vector3 _initialPosition;
    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector2(x: transform.localPosition.x + eventData.delta.x, transform.localPosition.y);
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _initialPosition = transform.localPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = _initialPosition;
    }
}
