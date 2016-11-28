using UnityEngine;
using System.Collections;

public class emailDeactivation : MonoBehaviour {

    public int deactivateTimer = 5;
    // Use this for initialization
    void Start () {
        Debug.Log("Start");
        StartCoroutine (emailViewer());

    }

    IEnumerator emailViewer()
    {
        Debug.Log("Timer started");


        yield return new WaitForSeconds(deactivateTimer);

        gameObject.SetActive(false);
        Debug.Log("Gameobject set to deactive");

    }
}
