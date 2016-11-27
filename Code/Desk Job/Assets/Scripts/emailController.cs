using UnityEngine;
using System.Collections;

public class emailController : MonoBehaviour {

    public GameObject [] emails;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < emails.Length; i++)
        {
            emails[i].gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
