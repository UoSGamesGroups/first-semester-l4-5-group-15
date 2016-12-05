using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

    //the current level
    public int lvl;
    //a multiplier with the level to create the final number of files instantiated per level
    public int Difficulty = 3;
    //Int to compare to lvl to determine if it has changed
    public GameObject[] Prefabs;
    public GameObject[] Folder;
    public int folderArraySize;
    public GameObject[] emails;
    public GameObject[] extraEmails;
    public RectTransform CanvasTransform;
    public float deactivateTimer = 3;
    public int numFiles;
    int timeChecker;

    // Use this for initialization
    void Start () {
        lvl++;
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

        if (numFiles == 0)
        {
            lvl++;
            LevelInit();
        }
        if (numFiles == (lvl * Difficulty)/2 && timeChecker == 0)
        {

            extraEmails[lvl].gameObject.SetActive(true);
            timeChecker++;

        }
	}

    void LevelInit ()
    {
        numFiles = 0;

        if (lvl == 2)
        {
            Folder[3].gameObject.SetActive(true);
        }
        if (lvl == 3)
        {
            Folder[4].gameObject.SetActive(true);
        }

        int activeFolders = 0;

        for (int i = 0; i < Folder.Length; i++)
        {
            if (Folder[i].gameObject.activeSelf)
                activeFolders++;
        }

        for (int i = 0; i < (lvl*Difficulty); i++)
        {
            
            GameObject newFile = Instantiate(Prefabs[Random.Range(0, activeFolders)], transform.position, Quaternion.identity) as GameObject;
            newFile.transform.SetParent(CanvasTransform);
            newFile.GetComponent<FilePosition>().SetPosition(CanvasTransform.sizeDelta);
            numFiles++;
        }

        Debug.Log("Instantiated " + numFiles + " objects");
        emails[lvl - 1].gameObject.SetActive(true);
        timeChecker = 0;

    }
}
