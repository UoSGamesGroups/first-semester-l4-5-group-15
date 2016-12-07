using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class FolderDrop : MonoBehaviour, IDropHandler {

    public FileMover.FileType Type;
    public LevelController Joice;
    public RectTransform CanvasTransform;

    public void OnDrop(PointerEventData eventData)
    {
        if ( FileMover.DraggedItem.Type == Type)
        {
            Debug.Log("You dragged it to the right place!");
            Destroy(FileMover.DraggedItem.gameObject);
            FileMover.DraggedItem = null;
            Joice.numFiles--;
        }
        else
        {
            FileMover.DraggedItem.GetComponent<FilePosition>().SetPosition(CanvasTransform.sizeDelta);
        }
    }
}
