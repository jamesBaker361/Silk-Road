using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	public float speed;             //Floating point variable to store the player's movement speed.

	//private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.

	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector2 ((transform.position.x - speed), transform.position.y);
		} else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
			transform.position = new Vector2 ((transform.position.x + speed), transform.position.y);
		}else if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			transform.position = new Vector2 ((transform.position.x), transform.position.y+speed);
		}else if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
			transform.position = new Vector2 ((transform.position.x), transform.position.y-speed);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
