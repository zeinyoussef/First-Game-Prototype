using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {
	public Text playerScore;
	public int score;
	void Awake (){
		score = 0;
		playerScore.text = ("Score: " + 0);
	}
	void Update(){
		playerScore.text = ("Score: " + score);
	}
}
