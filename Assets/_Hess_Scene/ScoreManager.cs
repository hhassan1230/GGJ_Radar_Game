using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public static ScoreManager instance;

	static Dictionary<string, float> PlayersScores = new Dictionary<string, float>();

	// Use this for initialization Singleton
	void Awake()
	{
		print ("I am alive!");
		if(instance == null)
		{
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		PlayersScores.Add("player1Score", 0f);
		PlayersScores.Add("player2Score", 0f);
		PlayersScores.Add("player3Score", 0f);
		PlayersScores.Add("player4Score", 0f);

		print ("P1 " + PlayersScores["player1Score"]);
	}

	public void updateScore(float addtion, int playerNum) {
		string updatedPlayer = "player" + playerNum + "Score";
		PlayersScores [updatedPlayer] += addtion;
		print ("Player " + playerNum + " is at " + PlayersScores [updatedPlayer]);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			updateScore (4f, 3);
			print("space key was pressed");

		}
	}
}
