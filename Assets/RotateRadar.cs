﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRadar : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		
	}

	void rotateObject(){
		transform.Rotate(Vector3.forward * speed);
	}
	
	// Update is called once per frame
	void Update () {
		rotateObject ();
	}
}
