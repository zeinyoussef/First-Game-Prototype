using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {


	public static GameObject player;
	public PlayerScore script;
	public PlayerMovement moveScript;

	// Update is called once per frame
	void Start(){
		player = GameObject.Find("Player");
		script = player.GetComponent<PlayerScore> ();
		moveScript = player.GetComponent<PlayerMovement> ();
	}

	void Update () {
		EnemyMove();
	}
	void EnemyMove(){
		//Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveScript.enemySpeed,0);
	}
	void OnCollisionEnter2D(Collision2D col){
		script.score += 1;
		Destroy (gameObject);
	}
}
