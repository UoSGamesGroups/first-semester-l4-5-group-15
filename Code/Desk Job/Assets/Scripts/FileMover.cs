using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class FileMover : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public enum FileType
    {
        Safe,
        Storage,
        Tree,
        Mail,
        Car
    };

    public static FileMover DraggedItem;

    public FileType Type;

    public void OnBeginDrag(PointerEventData eventData)
    {
        DraggedItem = this;
        GetComponent<Image>().raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<Image>().raycastTarget = true;
        DraggedItem = null;
    }
}