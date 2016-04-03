using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    bool inRange;
    bool active;
    GameObject player;
    public GameObject glass, target;
    Vector3 buttonTarget, posChange;

    // Use this for initialization
    void Start() {
        inRange = false;
        active = false;
        player = GameObject.Find("Player");
        posChange = new Vector3(0.0f, 0.0f, 0.2f);
        buttonTarget = transform.position - posChange;
    }

    // Update is called once per frame
    void Update() {
        inRange = (Vector3.Distance(transform.position, player.transform.position) < 3.0f);

        //if (inRange) {
        //    Debug.Log("inRange!!");
        //}

        if (inRange && Input.GetButtonDown("LeftButton") && inRange && !active) {
            active = true;
        }
        if (active) {
            transform.position = Vector3.Lerp(transform.position, buttonTarget, 0.05f);
            glass.transform.position = Vector3.Lerp(glass.transform.position, target.transform.position, 0.02f);
        }
    }
}
