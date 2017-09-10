using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform enemyPrefab;

	public float timeBetweenWaves = 5.5f;
	private float countdown;

	void Awake(){
		countdown = timeBetweenWaves;


	}
	void Update(){
		if (countdown <= 0) {
			countdown = timeBetweenWaves;
			SpawnEnemy ();
		}

		countdown -= Time.deltaTime;
	}

	void SpawnEnemy(){
		Instantiate(enemyPrefab, gameObject.transform.position,gameObject.transform.rotation);
	}
}
