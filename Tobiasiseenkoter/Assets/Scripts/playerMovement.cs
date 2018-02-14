using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
	
	public int speed = 10;
	private bool moveRight = false;
	private bool moveLeft = false;
	private bool moveForward = false;
	private bool moveBackward = false;

	// Use this for initialization
	void Update () {
		if (Input.GetKey("w")){
			moveForward = true;
		}
		if (Input.GetKey("a")){
			moveLeft = true;
		}
		if (Input.GetKey("s")){
			moveBackward = true;
		}
		if (Input.GetKey("d")){
			moveRight = true;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (moveForward == true){
			transform.position += transform.forward * Time.deltaTime * speed;
			moveForward = false;
		}
		if (moveBackward == true){
			transform.position -= transform.forward * Time.deltaTime * speed;
			moveBackward = false;
		}
		if (moveRight == true){
			transform.position += transform.right * Time.deltaTime * speed;
			moveRight = false;
		}
		if (moveLeft == true){
			transform.position -= transform.right * Time.deltaTime * speed;
			moveLeft = false;
		}
	}
}
