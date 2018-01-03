using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	// create a rigidBody to which we will apply the forces
	private Rigidbody rb;
	private int count;
	public float speed;
	// object of type text, it's a reference to the text UI element
	public Text countText;

	void Start() {
		count = 0;
		// get the rigidbody of the component to which the script is attached
		rb = GetComponent<Rigidbody>();
		updateText ();
	}

	void FixedUpdate() {
		// collect the input from the user
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// create a Vector3 object from the users input
		Vector3 movement = new Vector3 (moveHorizontal,0.0f, moveVertical);

		// apply the forces to the RigidBody
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			updateText ();
		}
	}
		
	void updateText() {
		countText.text = "Count = " + count.ToString ();
	}

}
