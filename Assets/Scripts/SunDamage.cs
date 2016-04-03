using UnityEngine;
using System.Collections;

public class SunDamage : MonoBehaviour {
	private GameObject sceneLight;
    private int layerMask = ~(1 << 8);
    public Material damageMat;

	// Use this for initialization
	void Start () {
        sceneLight = GameObject.Find("Directional Light");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("RightButton"))
        {
            Debug.Log("HI");
        }
        //Apply damage to player
        if (!(Physics.Raycast(transform.position, -1.0f * sceneLight.transform.forward, Mathf.Infinity, layerMask)))
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
        Color newColor = damageMat.GetColor("_Color");
        newColor.a = Mathf.Clamp(newColor.a + delta, 0, 0.9f);
        damageMat.SetColor("_Color", newColor);
    }
}
