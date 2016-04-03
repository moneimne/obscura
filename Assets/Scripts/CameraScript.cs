using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public float angular_speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Camera controls
        transform.Rotate(transform.right * Input.GetAxis("RightStickVertical") * angular_speed, Space.World);
        transform.parent.transform.Rotate(Vector3.up * Input.GetAxis("RightStickHorizontal") * angular_speed * 1.3f, Space.World);
	}
}
