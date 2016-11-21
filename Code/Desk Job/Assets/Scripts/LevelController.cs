using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

    public int lvl;
    public GameObject[] Prefabs;
    public RectTransform CanvasTransform;

	// Use this for initialization
	void Start () {
        lvl = 1;
        LevelInit(lvl);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void LevelInit (int Level)
    {
        for (int i = 0; i < (Level*30); i++)
        {
            GameObject newFile = Instantiate(Prefabs[Random.Range(0,Prefabs.Length)], transform.position, Quaternion.identity) as GameObject;
            newFile.transform.SetParent(CanvasTransform);
            newFile.GetComponent<FilePosition>().SetPosition(CanvasTransform.sizeDelta);
        }
    }
}
