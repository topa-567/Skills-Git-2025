using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject altar;
	bool Spawned;
	Vector3 SpawnedPosition;
	// Use this for initialization

	void Start () {
		Spawned = false;
		SpawnedPosition = new Vector3 (3.476466f, 5.341311f, 0f);

		if (Spawned == false) {
			Instantiate (altar, SpawnedPosition, Quaternion.identity);
			Spawned = true;
			Debug.Log ("Alter Spawned");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void SpawnedAltar() {

	}

}
