using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

    //the current level
    public int lvl;
    //a multiplier with the level to create the final number of files instantiated per level
    public int Difficulty = 3;
    //Int to compare to lvl to determine if it has changed
    int currentLvl;
    public GameObject[] Prefabs;
    public GameObject[] emails;
    public GameObject[] extraEmails;
    public RectTransform CanvasTransform;
    public float deactivateTimer = 5;

    // Use this for initialization
    void Start () {
        lvl = 1;
        currentLvl = lvl;
        LevelInit();

        /*
         * //pointless code, not useful anymore
        //set all emails to inactive
        for (int i = 0; i < emails.Length; i++)
        {
            emails[i].gameObject.SetActive(false);
        }
        //set all extra emails to inactiuve
        for (int i = 0; i < extraEmails.Length; i++)
        {
            extraEmails[i].gameObject.SetActive(false);
        }
        */
    }
	
	// Update is called once per frame
	void Update () {

        if (lvl != currentLvl)
        {
            currentLvl = lvl;
            LevelInit();
        }
	}

    void LevelInit ()
    {
        for (int i = 0; i < (lvl*Difficulty); i++)
        {
            
            GameObject newFile = Instantiate(Prefabs[Random.Range(0,Prefabs.Length)], transform.position, Quaternion.identity) as GameObject;
            newFile.transform.SetParent(CanvasTransform);
            newFile.GetComponent<FilePosition>().SetPosition(CanvasTransform.sizeDelta);
        }
        Debug.Log("Instantiated " + lvl*Difficulty + " objects");

    }

}
