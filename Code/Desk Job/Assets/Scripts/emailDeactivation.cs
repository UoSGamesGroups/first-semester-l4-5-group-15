using UnityEngine;
using System.Collections;

public class emailDeactivation : MonoBehaviour {

    // Use this for initialization
    public void DisableEmail () {
        Debug.Log("Start");
        gameObject.SetActive(false);
    }
}
