using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Title Light").transform.eulerAngles.x < 23.0f) {
			Application.LoadLevel ("SunTesting");
		}
	}
}
