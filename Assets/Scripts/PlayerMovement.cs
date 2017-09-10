using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	public int playerSpeed = 10;
	private float moveX, moveY;
	public Text gameOverText;
	public float enemySpeed = -5f;
	public float speedIncreaseCount = 0f;


	void Awake(){
		gameOverText.enabled = false;
	}
	// Update is called once per frame
	void Update () {
		PlayerMove();
		speedIncreaseCount += Time.deltaTime;
		if (speedIncreaseCount >= 5f) {
			enemySpeed -= 0.4f;
			speedIncreaseCount = 0;
		}
	}
	void PlayerMove(){
		//CONTROLS
		moveX = Input.GetAxis("Horizontal");
		moveY = Input.GetAxis ("Vertical");
		//Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX*playerSpeed,moveY*playerSpeed);
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			Destroy (gameObject);
			Time.timeScale = 0;
			gameOverText.enabled = true;
		}

	}
}
