using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	void Start() {
		offset = transform.position - player.transform.position;
	}

	// late update gets executed, every frame, after all items has been processed in update
	void LateUpdate() {
		transform.position = player.transform.position + offset;
	}

}
