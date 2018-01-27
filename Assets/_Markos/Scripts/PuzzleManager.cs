using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour {

    public GameObject TextBox;
    public int Number1;
    public int Number2;
    public int Number3;
    public int Number4;
    public int Number5;
    public int Number6;

    public void CheckInput() {
        for(int i=1; i <7; i++) {

        }
    }
    // Use this for initialization
    void Start() {
        Number1 = Random.Range(0, 9);
        Number2 = Random.Range(0, 9);
        Number3 = Random.Range(0, 9);
        Number4 = Random.Range(0, 9);
        Number5 = Random.Range(0, 9);
        Number6 = Random.Range(0, 9);
        TextBox.GetComponent<Text>().text = "" + Number1 + Number2 + Number3 + Number4 + Number5 + Number6;

    }

    // Update is called once per frame
    void Update() {

    }
}

