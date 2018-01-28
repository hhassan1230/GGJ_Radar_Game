using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrientationTest : MonoBehaviour {

	public Text textbox;

	// Use this for initialization
	void Start () {
		textbox.text = "Device Orientation: FaceUp";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.deviceOrientation == DeviceOrientation.FaceDown) {
			textbox.text = "Device Orientation: FaceDown";
		} else if (Input.deviceOrientation == DeviceOrientation.FaceUp) {
			textbox.text = "Device Orientation: FaceUp";
		}
	}
}
