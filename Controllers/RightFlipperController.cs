using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipperController : MonoBehaviour {

    private HingeJoint hj;

	// Use this for initialization
	void Start () {
        hj = gameObject.GetComponent<HingeJoint>();
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        if (x == 1.0)
        {
            hj.useMotor = true;
        }
        else
        {
            hj.useMotor = false;
        }
    }
}
