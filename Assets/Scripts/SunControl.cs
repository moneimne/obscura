using UnityEngine;
using System.Collections;

public class SunControl : MonoBehaviour {
    float rotateX, rotateY, rotateZ;
    float sunSpeed;
    public Times curr;
    bool topReset;
    GameObject player;
    float timer = 0.0f;

    public enum Times { tt, tr, rr, br, bb, bl, ll, tl, up };

    // Use this for initialization
    void Start() {
        rotateX = 90.0f;
        rotateY = 0.0f;
        rotateZ = 0.0f;
        sunSpeed = 0.2f;
        curr = Times.up;
        topReset = true;
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.Euler(rotateX, rotateY, rotateZ);
        topReset = false;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update() {
        //if (timer > 0.05f) {
            // Check for sun control input.
            if (Input.GetButton("RightButton")) {
                //Debug.Log("HORIZ: " + Input.GetAxis("LeftStickHorizontal") + ", VERT: " + Input.GetAxis("LeftStickVertical"));
                Vector3 stickPos = new Vector3(Input.GetAxis("LeftStickHorizontal"), 0, Input.GetAxis("LeftStickVertical"));
                //Debug.Log(stickPos);
                if (Input.GetButtonDown("LeftStickTrigger")) {
                    topReset = true;
                    curr = Times.up;
                }

                //Debug.Log(stickPos + " ... " + Input.GetButtonDown("LeftStickTrigger"));

                if (Mathf.Abs(stickPos.x) < 0.1f && stickPos.z > 0.9f) {
                    curr = Times.tt;
                }
                else if (stickPos.x > 0.9f && stickPos.z > 0.9f) {
                    curr = Times.tr;
                }
                else if (stickPos.x > 0.9f && Mathf.Abs(stickPos.z) < 0.1f) {
                    curr = Times.rr;
                }
                else if (stickPos.x > 0.9f && stickPos.z < -0.9f) {
                    curr = Times.br;
                }
                else if (Mathf.Abs(stickPos.x) < 0.1f && stickPos.z < -0.9f) {
                    curr = Times.bb;
                }
                else if (stickPos.x < -0.9f && stickPos.z < -0.9f) {
                    curr = Times.bl;
                }
                else if (stickPos.x < -0.9f && Mathf.Abs(stickPos.z) < 0.1f) {
                    curr = Times.ll;
                }
                else if (stickPos.x < -0.9f && stickPos.z > 0.9f) {
                    curr = Times.tl;
                }

                if (Mathf.Abs(stickPos.x) + Mathf.Abs(stickPos.z) > 0.8f) {
                    float octant = player.transform.rotation.eulerAngles.y / 45.0f;
                    if (octant - Mathf.Floor(octant) < 0.5) {
                        octant = Mathf.Floor(octant);
                    }
                    else {
                        octant = Mathf.Ceil(octant);
                    }
                    int temp = (int)curr + (int)octant;
                    temp = (((temp % 8) + 8) % 8);
                    curr = (SunControl.Times)temp;
                    //Debug.Log("curr: " + curr + ", posY: " + player.transform.rotation.eulerAngles.y + ", temp: " + temp + ", octant: " + octant);
                }
            }
        //    timer = 0.0f;
        //}
        //else {
        //    timer += Time.deltaTime;
        //}
        if (Mathf.Abs(transform.rotation.eulerAngles.y - ((((float)curr * 45.0f) + 180.0f) % 360.0f)) > 0.1f && curr != Times.up) {
            //float currentAngle = transform.rotation.eulerAngles.y;
            //float targetAngle = (float)curr * 45.0f;
            //float angleBetween = ((targetAngle - currentAngle) + 180.0f) % 360.0f - 180.0f;
            //if (angleBetween > 0)
            //{
            //    transform.Rotate(Vector3.up, sunSpeed, Space.World);
            //}
            //else
            //{
            //    transform.Rotate(Vector3.up, -1 * sunSpeed, Space.World);
            //}
            transform.Rotate(Vector3.up, sunSpeed, Space.World);
        }

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
        }



    }
}
