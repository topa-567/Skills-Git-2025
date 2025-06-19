using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HeroMovement : MonoBehaviour {

	Rigidbody2D rb;
	float speed;
	bool vulnerable;
	public int lives;
	// Use this for initialization
	public void setlives(){
		lives -= 1;
		if (lives <= -1)
		{
			Debug.Log("End of game");
			SceneManager.LoadScene ("Lost");
		}
	}
	void Start () {
		speed = 5.1f;
		rb=GetComponent<Rigidbody2D>();
		lives = 3;
		vulnerable = false;
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.RightArrow))
			Input.GetKey (KeyCode.LeftArrow);
		{
			
			transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * speed, 0, 0);
		
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {

			rb.AddForce (Vector2.up * 300);
		}
	}
		
		void resetPosition()
		{
			Debug.Log ("SPIKED RECEIVED");
			transform.SetPositionAndRotation (new Vector3 (-4.77f, 0.16f, 0), Quaternion.identity);
		setlives ();
		}
	private void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Extra Life") {
			lives += 1;
			Destroy (other.gameObject);
		} else if (other.gameObject.tag == "vulnerable") {
			Destroy (other.gameObject);
			vulnerable = true;
			Debug.Log ("vulnerable = true!");
			StartCoroutine("VulnerableDeBuff");
		}
	}
			IEnumerator VulnerableDeBuff()
			{
		yield return new WaitForSeconds(5f);
				vulnerable = false;
				Debug.Log("vulnerable = false!");
			}
			}
	

