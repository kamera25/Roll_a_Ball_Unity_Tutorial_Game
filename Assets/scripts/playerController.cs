using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// create a rigidBody to which we will apply the forces
	private Rigidbody rb;

	void Start() {
		// get the rigidbody of the component to which the script is attached
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		// collect the input from the user
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// create a Vector3 object from the users input
		Vector3 movement = new Vector3 (moveHorizontal,0.0f, moveVertical);

		// apply the forces to the RigidBody
		rb.AddForce (movement);
	}

}
