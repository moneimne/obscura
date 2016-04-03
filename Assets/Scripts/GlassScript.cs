using UnityEngine;
using System.Collections;

public class GlassScript : MonoBehaviour {
	public int number;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 sunDir = GameObject.Find ("Directional Light").transform.rotation.eulerAngles;
		RaycastHit hit;
		Physics.Raycast (transform.position, -sunDir, out hit);
		if (hit.distance > 300.0f) {
			switch (number) {
			case 1:
				// Raise towers + contents!
				break;
			}
		}
	}
}
