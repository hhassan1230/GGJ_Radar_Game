using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarScript : MonoBehaviour {

	public GUITexture radarBlip;
	public float timer = 2.0f; //Something to comment out...
	private bool blink = false;
	public float speed = 0.5f;
	//Collider2D collider;


	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpeedUp", 10f, 3f);
	}

	void SpeedUp() {
		speed += 1f;
	}
	
	// Update is called once per frame
	void Update () {
			rotateObject ();

		//
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 2.0f;
			blink = true;
		}
		if (blink == true) {
			Debug.Log ("Blink: " + blink);

			blink = false;
		}
	}

	void rotateObject(){
		transform.Rotate(Vector3.forward * speed);
	}

	void OnTriggerEnter2D(Collider2D col){
		//Debug.Log ("Touch");
		Collider2D collider;

		//Access the RadarObserver script and try to get value associated within Dictionary.
//		  if (RadarObserver.colliders.TryGetValue(col.gameObject, out collider)) {
//			 Debug.Log (System.String.Format ("<color=yellow>Got Collider!</color>"));
//			 collider.enabled = false;
//		 }
			
		if(col.gameObject.tag == "Player")
		{
			Debug.Log (System.String.Format ("<color=red>Hit!</color>"));
			Destroy(col.gameObject);
		}
	}
}
