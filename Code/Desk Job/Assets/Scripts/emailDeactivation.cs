using UnityEngine;
using System.Collections;

public class emailDeactivation : MonoBehaviour {

    public GameObject Email;
    // Use this for initialization
    void DisableEmail () {
        Debug.Log("Start");
        Email.gameObject.SetActive(false);

    }
}
