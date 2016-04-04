using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    private Rigidbody rb;
    public float Speed;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        // Movement controls
        if (!Input.GetButton("RightButton")) {
            Vector3 movement = new Vector3(Input.GetAxis("LeftStickHorizontal"), 0, Input.GetAxis("LeftStickVertical"));
            if (movement.sqrMagnitude > 0.5f) {
                movement.Normalize();
                if (Input.GetAxis("Run") > 0) {
                    movement *= 4.0f;
                }
                rb.MovePosition(transform.position + transform.TransformVector(movement) * Time.deltaTime * Speed);
            }
        }
    }
}
