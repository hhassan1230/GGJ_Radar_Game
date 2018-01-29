using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleRotation : MonoBehaviour {
	public static TitleRotation instance;

	public float speed;
	private int counter;
	private GameObject Title;
	private GameObject instructions;
	// Use this for initialization
	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		counter = 0;
		Title = GameObject.FindGameObjectWithTag ("Title");
		instructions = GameObject.FindGameObjectWithTag ("Text");
		Title.SetActive (false);
		instructions.SetActive (false);
	}

	void rotateObject(){
		transform.Rotate(Vector3.forward * speed);
	}

	public void UpdateCounter() {
		counter += 1;
		print ("Counter " + counter);
		if  (counter == 3) {
			Title.SetActive (true);
			StartCoroutine ("ShowInstructions");
			// Display Title
		}
	}

	private IEnumerator ShowInstructions()
	{
		yield return new WaitForSeconds(1.5f);
		instructions.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		rotateObject ();
		if (Input.anyKey) {
			SceneManager.LoadScene("Instructions", LoadSceneMode.Single);
		}
	}
}
