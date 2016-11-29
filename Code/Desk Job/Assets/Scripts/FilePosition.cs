using UnityEngine;
using System.Collections;

public class FilePosition : MonoBehaviour {

    private RectTransform rectT;
    private float width;
    private float height;

    void Start()
    {
        rectT = GetComponent<RectTransform>();
        width = rectT.sizeDelta.x;
        height = rectT.sizeDelta.y;
    }

	public void SetPosition(Vector2 size)
    {
        float left = -(size.x / 2);
        float right = size.x / 2;
        float top = -(size.y / 2);
        float bottom = size.y / 2;

        float xPos = Random.Range(left + width, right - width);
        float yPos = Random.Range(top + height, bottom - height);

        transform.localPosition = new Vector2(xPos, yPos);

    }
}
