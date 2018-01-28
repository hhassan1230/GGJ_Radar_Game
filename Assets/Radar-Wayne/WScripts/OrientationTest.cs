using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrientationTest : MonoBehaviour {

	public Text textbox;
	public Text timerText;
	public float timer = 30f;
	private bool isCount;
	private bool isCoolDown;

	// Use this for initialization
	void Start () {
		textbox.text = "Device Orientation: FaceUp";
		//timerText.text = "Timer: " + timer;
		isCount = true;
		isCoolDown = false;
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = "Timer: " + timer;
		//
		if (isCount) {
			if (isCoolDown) {
				// won't count down

			} else {
				timer -= Time.deltaTime;
			}
		} else {
			HandleCoolDown ();
			isCoolDown = true;
			isCount = true;
		}
		//
		if (Input.deviceOrientation == DeviceOrientation.FaceDown) {
			textbox.text = "Device Orientation: FaceDown";
			HandleCoolDown ();
		} else if (Input.deviceOrientation == DeviceOrientation.FaceUp) {
			textbox.text = "Device Orientation: FaceUp";
			isCount = true;
		}
	}

	public void HandleCoolDown(){
		StartCoroutine ("CoolDown");
		//CoolDown ();
	}

	IEnumerator CoolDown(){
		print ("Hi Ma");
		yield return new WaitForSeconds (2f);
		timer = 30f;
		isCount = true;
		isCoolDown = false;
	}

	public void ButtonClick(){
		Debug.Log ("Clicked");
		isCount = false;
		//
		HandleCoolDown();
	}
}
