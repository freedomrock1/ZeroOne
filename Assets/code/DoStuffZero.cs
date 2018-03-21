using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStuffZero : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

	}
	// called just before perfoming any physics
	void FixedUpdate() {
		//Vector3 force=(10,10,0);
		float mh=Input.GetAxis ("Horizontal");
		float mv = Input.GetAxis ("Vertical");

		Vector3 force=new Vector3(mh,0,mv);

		rb.AddForce (force*speed);

	}
}
