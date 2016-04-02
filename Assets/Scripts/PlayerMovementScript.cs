using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    private Rigidbody rb;
    public float Speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // Movement controls
        Vector3 movement = new Vector3(Input.GetAxis("LeftStickHorizontal"), 0, Input.GetAxis("LeftStickVertical"));
        if (movement.sqrMagnitude > 0.5f)
        {
            movement.Normalize();
            rb.MovePosition(transform.position + movement * Time.deltaTime * Speed);
        }
	}
}
