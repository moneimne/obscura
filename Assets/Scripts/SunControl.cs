using UnityEngine;
using System.Collections;

public class SunControl : MonoBehaviour {
    float rotateX, rotateY, rotateZ;
    float sunSpeed;
    Times curr;
    bool topReset;

    enum Times {tt, tr, rr, br, bb, bl, ll, tl, up};

	// Use this for initialization
	void Start () {
        rotateX = 50.0f;
        rotateY = 0.0f;
        rotateZ = 0.0f;
        sunSpeed = 0.2f;
        curr = Times.tt;
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(rotateX, rotateY, rotateZ);
        topReset = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Mathf.Abs(transform.rotation.eulerAngles.y - ((float) curr * 45.0f)) > 0.1f && curr != Times.up) {
            transform.Rotate(Vector3.up, sunSpeed, Space.World);
        }

<<<<<<< HEAD
        if (Mathf.Abs(transform.rotation.eulerAngles.x - 50.0f) > 0.5f && curr != Times.up) {
            if (topReset) {
                topReset = false;
                float dist = Mathf.Abs(transform.rotation.eulerAngles.y - ((float)curr * 45.0f));
                if (transform.rotation.eulerAngles.y > ((float)curr * 45.0f)) {
                    dist = 360.0f - dist;
                }
                transform.Rotate(Vector3.up, dist, Space.World);
            }
            transform.Rotate(-Vector3.right, sunSpeed);
        }

        if (curr == Times.up && Mathf.Abs(transform.rotation.eulerAngles.x - 90.0f) > 0.2f) {
            transform.Rotate(Vector3.right, sunSpeed);
=======
        Vector3 stickPos = new Vector3(Input.GetAxis("LeftStickHorizontal"), 0, Input.GetAxis("LeftStickVertical"));

        //if (Input.GetButtonDown("LeftStickTrigger"))
        //{
        //    Debug.Log("hey");
        //}

        //Debug.Log(stickPos + " ... " + Input.GetButtonDown("LeftStickTrigger"));
        if (stickPos.x == 0 && stickPos.z == 1) {
            curr = Times.tt;
        }
        else if (stickPos.x == 1 && stickPos.z == 1) {
            curr = Times.tr;
        }
        else if (stickPos.x == 1 && stickPos.z == 0) {
            curr = Times.rr;
        }
        else if (stickPos.x == 1 && stickPos.z == -1) {
            curr = Times.br;
        }
        else if (stickPos.x == 0 && stickPos.z == -1) {
            curr = Times.bb;
        }
        else if (stickPos.x == -1 && stickPos.z == -1) {
            curr = Times.bl;
>>>>>>> bb870209d57d588ea0720e511f5873f43f9c11cf
        }

        if (Input.GetButton("RightButton")) {
            Vector3 stickPos = new Vector3(Input.GetAxis("LeftStickHorizontal"), 0, Input.GetAxis("LeftStickVertical"));

            if (Input.GetButtonDown("LeftStickTrigger")) {
                topReset = true;
                curr = Times.up;
            }

            //Debug.Log(stickPos + " ... " + Input.GetButtonDown("LeftStickTrigger"));

            if (stickPos.x == 0 && stickPos.z == 1) {
                curr = Times.tt;
            }
            else if (stickPos.x == 1 && stickPos.z == 1) {
                curr = Times.tr;
            }
            else if (stickPos.x == 1 && stickPos.z == 0) {
                curr = Times.rr;
            }
            else if (stickPos.x == 1 && stickPos.z == -1) {
                curr = Times.br;
            }
            else if (stickPos.x == 0 && stickPos.z == -1) {
                curr = Times.bb;
            }
            else if (stickPos.x == -1 && stickPos.z == -1) {
                curr = Times.bl;
            }
            else if (stickPos.x == -1 && stickPos.z == 0) {
                curr = Times.ll;
            }
            else if (stickPos.x == -1 && stickPos.z == 1) {
                curr = Times.tl;
            }
        }
    }
}
