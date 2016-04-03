using UnityEngine;
using System.Collections;

public class SunDamage : MonoBehaviour {
	private Rigidbody rb;
	private GameObject light;
    private int layerMask = ~(1 << 8);
    private GUITexture damage;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		light = GameObject.Find ("Directional Light");
        damage = transform.Find("Damage").GetComponent<GUITexture>();
    }
	
	// Update is called once per frame
	void Update () {
        //Apply damage to player
        if (!(Physics.Raycast(transform.position, -1.0f * light.transform.forward, Mathf.Infinity, layerMask)))
        {
            addDamageAlpha(0.005f);
        }
        else
        {
            addDamageAlpha(-0.02f);
        }
	}

    void addDamageAlpha(float delta)
    {
        Color newColor = damage.color;
        newColor.a = Mathf.Clamp(newColor.a + delta, 0, 0.6f);
        damage.color = newColor;
    }
}
