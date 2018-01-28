using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRadar : MonoBehaviour {
	private GameObject radarScan;
	private GameObject radar;
	// Use this for initialization
	void Start () {
		Vector2 position = new Vector2 (-354.87f, -391.37f);
		// -354.75
		radarScan = GameObject.FindGameObjectWithTag ("radar-scan");
		radar = GameObject.FindGameObjectWithTag ("radar");
		radar.transform.localPosition = position;
		radarScan.transform.localPosition = new Vector2(-354.75f, position.y);
	}

}
