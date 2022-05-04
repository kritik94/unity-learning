using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookV2 : MonoBehaviour
{
	public float sensitivityHor = 3.0f;
	public float sensitivityVert = 3.0f;
	
	public float minimumVert = -45.0f;
	public float maximumVert = 45.0f;

	public Camera playerCam;
	
	void Start() {
		// Make the rigid body not change rotation
		Rigidbody body = GetComponent<Rigidbody>();
		if (body != null) {
			body.freezeRotation = true;
		}
	}

	void Update() {
		transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);

		var camRotateVert = playerCam.transform.localEulerAngles.x;
		if (camRotateVert > 180)
		{
			camRotateVert -= 360;
		}
		camRotateVert -= Input.GetAxis("Mouse Y") * sensitivityVert;
		camRotateVert = Mathf.Clamp(camRotateVert, minimumVert, maximumVert);

		playerCam.transform.localEulerAngles = new Vector3(camRotateVert, 0, 0);
	}
}
