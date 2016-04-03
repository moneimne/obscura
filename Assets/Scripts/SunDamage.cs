using UnityEngine;
using System.Collections;

public class SunDamage : MonoBehaviour {
	private Rigidbody rb;
	private GameObject light;
    private int layerMask = ~(1 << 8);

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		light = GameObject.Find ("Directional Light");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        if (!(Physics.Raycast(transform.position, -1.0f * light.transform.forward, Mathf.Infinity, layerMask)))
        //if (Physics.Raycast(transform.position, fwd, Mathf.Infinity, layerMask))
        {
            // Apply damage to player.
            Debug.Log("OUCH");
        }
        else
        {
            Debug.Log("NOT OUCH");
        }
	}
}
