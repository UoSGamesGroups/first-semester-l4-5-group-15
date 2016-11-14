using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class FolderDrop : MonoBehaviour, IDropHandler {

    public FileMover.FileType Type;

    public void OnDrop(PointerEventData eventData)
    {
        if ( FileMover.DraggedItem.Type == Type)
        {
            Debug.Log("You dragged it to the right place!");
            Destroy(FileMover.DraggedItem.gameObject);
            FileMover.DraggedItem = null;
        }
    }
}
