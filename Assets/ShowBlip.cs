using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBlip : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) 
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag("radar-scan"))
		{
			print ("It Finally worked");
			bool isRendering = gameObject.GetComponent<SpriteRenderer> ().enabled;
			if (!isRendering) {
				TitleRotation.instance.UpdateCounter ();
				gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			}
			// other.gameObject.SetActive(false);
		}
	}


}
