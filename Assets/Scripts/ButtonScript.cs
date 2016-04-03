using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    bool inRange;

	// Use this for initialization
	void Start () {
        inRange = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (inRange && Input.GetButtonDown("LeftButton")) {
            transform.Translate(50.0f, 0.0f, 0.0f);
        }
	}

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name.Equals("Player")) {
            inRange = true;
        }
    }

    void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name.Equals("Player")) {
            inRange = false;
        }
    }
}
