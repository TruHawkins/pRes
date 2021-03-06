using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {
	public GameObject spawn;
	public int spawn_rate;
	public int enemyMax;
	public int spawnRadius;
	public GameObject[] positions;

	int enemyCount = 0;

	Vector3[] pos;
	int timer = 0;
	int p_itr;
	GameObject player;
	bool activated = false;

	void Start(){
		player = GameObject.Find ("Player");
	}
		
	void Update () {
		if (!activated) {
			float dist = Vector3.Distance (transform.position, player.transform.position);
			if (dist < spawnRadius) {
				beginSpawning ();
			}
		} else {
			timedSpawn ();
		}
	}

	void beginSpawning(){
		//Debug.Log ("starting");
		pos = new Vector3[positions.Length];
		for(int i = 0; i < positions.Length; i++) {
			pos [i] = positions [i].transform.position;
		}

		activated = true;
	}

	void timedSpawn(){
		//Debug.Log ("spawning");
		if (timer > spawn_rate && enemyCount < enemyMax) {
			Instantiate (spawn, pos [p_itr], transform.rotation);
			p_itr = (p_itr + 1) % positions.Length;
			enemyCount++;
			//Debug.Log (p_itr);
			timer = 0;
		} else {
			timer++;
		}
	}
}
