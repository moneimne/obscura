using UnityEngine;
using System.Collections;

public class DamageTextureScript : MonoBehaviour {
    Camera camera;

	// Use this for initialization
	void Start () {
        camera = transform.parent.gameObject.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0.5f, 0.5f, 0.0f);
	}
}
