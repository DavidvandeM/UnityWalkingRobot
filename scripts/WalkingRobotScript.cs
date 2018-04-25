using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingRobotScript : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per videoframe
	void FixedUpdate ()
    {
        float h = Input.GetAxis("Horizontal");
        anim.SetFloat("Direction", h);
        float v = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", v);
	}
}
