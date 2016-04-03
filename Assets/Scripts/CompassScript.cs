using UnityEngine;
using System.Collections;

public class CompassScript : MonoBehaviour {
    SunControl.Times active;
    GameObject compass;
    GameObject tt;
    GameObject tr;
    GameObject rr;
    GameObject br;
    GameObject bb;
    GameObject bl;
    GameObject ll;
    GameObject tl;
    GameObject up;
    GameObject r0;
    GameObject r1;
    GameObject r2;
    GameObject r3;
    GameObject r4;
    GameObject r5;
    GameObject r6;
    public Material active_mat;
    public Material inactive_mat;


    // Use this for initialization
    void Start() {
        compass = GameObject.Find("Compass");
        tt = compass.transform.Find("rotating_part/final_compass2/faces/UP").gameObject;
        tr = compass.transform.Find("rotating_part/final_compass2/faces/UP_RIGHT").gameObject;
        rr = compass.transform.Find("rotating_part/final_compass2/faces/RIGHT").gameObject;
        br = compass.transform.Find("rotating_part/final_compass2/faces/RIGHT_DOWN").gameObject;
        bb = compass.transform.Find("rotating_part/final_compass2/faces/DOWN").gameObject;
        bl = compass.transform.Find("rotating_part/final_compass2/faces/DOWN_LEFT").gameObject;
        ll = compass.transform.Find("rotating_part/final_compass2/faces/LEFT").gameObject;
        tl = compass.transform.Find("rotating_part/final_compass2/faces/LEFT_UP").gameObject;
        up = compass.transform.Find("rays/CENTER").gameObject;
        r0 = compass.transform.Find("rays/rays1/group2/polySurface93").gameObject;
        r1 = compass.transform.Find("rays/rays1/group2/polySurface94").gameObject;
        r2 = compass.transform.Find("rays/rays1/group2/polySurface96").gameObject;
        r3 = compass.transform.Find("rays/rays1/group2/polySurface97").gameObject;
        r4 = compass.transform.Find("rays/rays1/group2/polySurface98").gameObject;
        r5 = compass.transform.Find("rays/rays1/group2/polySurface99").gameObject;
        r6 = compass.transform.Find("rays/rays1/group2/polySurface100").gameObject;
        active = SunControl.Times.up;
    }

    // Update is called once per frame
    void Update() {
        SunControl.Times curr = GameObject.Find("Directional Light").GetComponent<SunControl>().curr;
        if (active != curr) {
            // Make the inactive dial white.
            switch (active) {
                case SunControl.Times.tt:
                    tt.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.tr:
                    tr.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.rr:
                    rr.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.br:
                    br.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.bb:
                    bb.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.bl:
                    bl.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.ll:
                    ll.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.tl:
                    tl.GetComponent<Renderer>().material = inactive_mat;
                    break;
                case SunControl.Times.up:
                    up.GetComponent<Renderer>().material = inactive_mat;
                    r0.GetComponent<Renderer>().material = inactive_mat;
                    r1.GetComponent<Renderer>().material = inactive_mat;
                    r2.GetComponent<Renderer>().material = inactive_mat;
                    r3.GetComponent<Renderer>().material = inactive_mat;
                    r4.GetComponent<Renderer>().material = inactive_mat;
                    r5.GetComponent<Renderer>().material = inactive_mat;
                    r6.GetComponent<Renderer>().material = inactive_mat;
                    break;
                default:
                    break;
            }
            // Make the inactive dial red.
            switch (curr) {
                case SunControl.Times.tt:
                    tt.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.tr:
                    tr.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.rr:
                    rr.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.br:
                    br.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.bb:
                    bb.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.bl:
                    bl.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.ll:
                    ll.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.tl:
                    tl.GetComponent<Renderer>().material = active_mat;
                    break;
                case SunControl.Times.up:
                    up.GetComponent<Renderer>().material = active_mat;
                    r0.GetComponent<Renderer>().material = active_mat;
                    r1.GetComponent<Renderer>().material = active_mat;
                    r2.GetComponent<Renderer>().material = active_mat;
                    r3.GetComponent<Renderer>().material = active_mat;
                    r4.GetComponent<Renderer>().material = active_mat;
                    r5.GetComponent<Renderer>().material = active_mat;
                    r6.GetComponent<Renderer>().material = active_mat;
                    break;
                default:
                    break;
            }
            active = curr;
        }
    }
}
