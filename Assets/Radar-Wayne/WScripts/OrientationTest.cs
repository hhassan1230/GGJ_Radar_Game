using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrientationTest : MonoBehaviour {

	public Text textbox;
	public Text timerText;
	public float timer = 30f;
	private bool isCount;

	// Use this for initialization
	void Start () {
		textbox.text = "Device Orientation: FaceUp";
		//timerText.text = "Timer: " + timer;
		isCount = true;
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = "Timer: " + timer;
		//
		if (isCount) {
			timer -= Time.deltaTime;
		}
		//
		if (Input.deviceOrientation == DeviceOrientation.FaceDown) {
			textbox.text = "Device Orientation: FaceDown";
			isCount = false;
		} else if (Input.deviceOrientation == DeviceOrientation.FaceUp) {
			textbox.text = "Device Orientation: FaceUp";
			isCount = true;
		}
	}
}
