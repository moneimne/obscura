using UnityEngine;
using System.Collections;

public class SunDamage : MonoBehaviour {
	private Rigidbody rb;
	private GameObject light;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		light = GameObject.Find ("Directional Light");
	}
	
	// Update is called once per frame
	void Update () {
		if (!(Physics.Raycast(transform.position, light.transform.forward, 100))) 
			// Apply damage to player.
			Debug.Log("OUCH");
	}
}
