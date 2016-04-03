using UnityEngine;
using System.Collections;

public class GlassScript : MonoBehaviour {
    public GameObject glassTarget;
    public GameObject tower2, tower3, tower4, towerFinal;
    bool buttonPressed = false;
    Vector3 finalTowerPos;
    float towerStartY;

	// Use this for initialization
	void Start () {
        //finalTowerPos = towerFinal.transform.position;
        if (towerFinal != null)
        {
            towerStartY = towerFinal.transform.position.y;
        }
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 sunDir = GameObject.Find("Directional Light").transform.forward;
        if (sunDir.y < -0.95f)
        {
            if ((glassTarget.transform.position - transform.position).magnitude < 0.1f)
            {
                //-79.8 to 0
                if (towerFinal == null)
                {
                    tower2.transform.position = Vector3.Lerp(tower2.transform.position, new Vector3(tower2.transform.position.x, 0.0f, tower2.transform.position.z), 0.01f);
                    tower3.transform.position = Vector3.Lerp(tower3.transform.position, new Vector3(tower3.transform.position.x, 0.0f, tower3.transform.position.z), 0.01f);
                    tower4.transform.position = Vector3.Lerp(tower4.transform.position, new Vector3(tower4.transform.position.x, 0.0f, tower4.transform.position.z), 0.01f);
                }
                //-173.9 to 0
                else
                {
                    towerFinal = GameObject.Find("big_tower");
                    if (!buttonPressed)
                    {
                        buttonPressed = true;
                        finalTowerPos = new Vector3(towerFinal.transform.position.x,
                        towerFinal.transform.position.y + -1 * (2.0f*towerStartY / 3.0f),
                        towerFinal.transform.position.z);
                    }
                    towerFinal.transform.position = Vector3.Lerp(towerFinal.transform.position, finalTowerPos, 0.01f);
                }
            }
        }
	}
}
