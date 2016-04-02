using UnityEngine;
using System.Collections;

public class SunControl : MonoBehaviour {
    float rotateX, rotateY, rotateZ;
    float sunSpeed;
    Times curr;

    enum Times {tt, tr, rr, br, bb, bl, ll, tl};

	// Use this for initialization
	void Start () {
        rotateX = 50.0f;
        rotateY = 0.0f;
        rotateZ = 0.0f;
        sunSpeed = 0.2f;
        curr = Times.tt;
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(rotateX, rotateY, rotateZ);
	}
	
	// Update is called once per frame
	void Update () {
        if (Mathf.Abs(transform.rotation.eulerAngles.y - ((float) curr * 45.0f)) > 0.1f) {
            transform.Rotate(Vector3.up, sunSpeed, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            curr = Times.tt;
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            curr = Times.tr;
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            curr = Times.rr;
        }
        else if (Input.GetKeyDown(KeyCode.F)) {
            curr = Times.br;
        }
        else if (Input.GetKeyDown(KeyCode.G)) {
            curr = Times.bb;
        }
        else if (Input.GetKeyDown(KeyCode.H)) {
            curr = Times.bl;
        }
        else if (Input.GetKeyDown(KeyCode.J)) {
            curr = Times.ll;
        }
        else if (Input.GetKeyDown(KeyCode.K)) {
            curr = Times.tl;
        }
    }
}
