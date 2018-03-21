using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoStuff : MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector3 (0.0f, 1.0f, 0.0f);
		Vector3 force = new Vector3 (0.0f, 0.0f, 0.0f);
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.MovePosition (pos);
			rb.velocity = force;
			rb.angularVelocity = force;
		}
	}
	// called just before perfoming any physics
	void FixedUpdate() {
		//Vector3 force=(10,10,0);
		float mh=Input.GetAxis ("Horizontal");
		float mv = Input.GetAxis ("Vertical");

		

	}
}
