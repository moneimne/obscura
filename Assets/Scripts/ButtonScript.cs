using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
    public int number;
    bool inRange;
    bool active;
    GameObject glass, player;
    Vector3 buttonTarget, glassTarget, posChange;

    // Use this for initialization
    void Start() {
        inRange = false;
        active = false;
        glass = GameObject.Find("Magnifying Glass " + number);
        player = GameObject.Find("Player");
        posChange = new Vector3(0.0f, 0.0f, 0.2f);
        buttonTarget = transform.position - posChange;
        glassTarget = GameObject.Find("Glass Target " + number).transform.position;
    }

    // Update is called once per frame
    void Update() {
        inRange = (Vector3.Distance(transform.position, player.transform.position) < 3.0f);

        if (inRange) {
            Debug.Log("inRange!!");
        }

        if (inRange && Input.GetButtonDown("LeftButton") && inRange && !active) {
            active = true;
        }
        if (active) {
            transform.position = Vector3.Lerp(transform.position, buttonTarget, 0.05f);
            glass.transform.position = Vector3.Lerp(glass.transform.position, glassTarget, 0.1f);
        }
    }
}
