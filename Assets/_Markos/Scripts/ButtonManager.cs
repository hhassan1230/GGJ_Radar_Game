﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {
    public GameObject CurrentButton;
	private string button;
	public void PressButton(Text PressedButton) {
		button = PressedButton.text;
		PuzzleManager.instance.CurrentlyPressed (button);
    }
}
