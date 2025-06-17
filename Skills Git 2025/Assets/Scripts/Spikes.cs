using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	// Use this for initialization
	GameObject Hero;
	void Start () {
		Hero = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("SPIKED!");
		Hero.SendMessage ("resetPosition");
	}
	void resetPosition()
	{
		Debug.Log ("SPIKED RECEIVED");
		transform.SetPositionAndRotation (new Vector3 (-4.77f, 0.16f, 0), Quaternion.identity);
	} 

}
