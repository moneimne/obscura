using UnityEngine;
using System.Collections;

public class GlassScript : MonoBehaviour {
    public GameObject glassTarget;
    public GameObject tower2, tower3, tower4, towerFinal;
    bool buttonPressed = false;
    Vector3 finalTowerPos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        //RaycastHit hit;
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
                if (!buttonPressed)
                {
                    buttonPressed = true;
                    finalTowerPos = new Vector3(towerFinal.transform.position.x,
                    towerFinal.transform.position.y + ((2 * 173.9f) / 3.0f),
                    towerFinal.transform.position.z);
                }
                towerFinal.transform.position = Vector3.Lerp(towerFinal.transform.position, finalTowerPos, 0.01f);
            }
        }
	}
}
