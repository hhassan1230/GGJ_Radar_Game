using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoralRotate : MonoBehaviour {
	public float speed = -90f;
	// Use this for initialization
	void Start () {
		
	}

	void OrbitAround() {
		transform.RotateAround (Vector3.zero, Vector3.down, speed * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		// OrbitAround ();
		transform.Rotate(Vector3.forward * speed);
	}
}
