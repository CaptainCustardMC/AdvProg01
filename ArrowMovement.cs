using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {
	Quaternion front;
	PlayerControl pc;
	// Use this for initialization
	void Start () {
		pc = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerControl> ();
	//	front 
	}
	
	// Update is called once per frame
	void Update () {
		front = pc.transform.rotation;
		gameObject.transform.rotation = new Quaternion (front.x, front.z, -front.y, front.w);
		gameObject.transform.Rotate (new Vector3 (0, 0, 1), 180);
	}
}