using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour {

	public Rigidbody rb;

	public float angle;
	private float angleRad;
	private float xComp;
	private float zComp;

	public float handling;
	public float acceleration;
	public float speed;
	public float topSpeed;


	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody>();
	}

// Update is called once per frame
void Update () {

		angle = transform.localEulerAngles.y - 180;
		angleRad = angle / 180 * Mathf.PI;

		xComp = Mathf.Sin(angleRad);
		zComp = Mathf.Cos(angleRad);

		speed = rb.velocity.magnitude;

		if (Input.GetAxis("Vertical") != 0)
		{
			rb.AddForce(xComp, 0.0f, zComp * acceleration * Input.GetAxis("Vertical"));
		}


		if (Input.GetAxis("Horizontal") != 0 && speed > 4)
		{
			rb.angularVelocity = new Vector3(0.0f, Mathf.PI * handling / 10, 0.0f);
		}



	}
}
