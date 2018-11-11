using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour {

	public bool movingLeft = true;
	public bool movingRight = false;
	public float doorSpd;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	if (movingLeft && transform.localPosition.x < -1.6f)
		{
			movingLeft = false;
			movingRight = true;
		}
	if (movingRight && transform.localPosition.x > 1.3f)
		{
			movingLeft = true;
			movingRight = false;
		}

	if (movingLeft)
		{
			transform.position += new Vector3(-doorSpd, 0.0f, 0.0f);
		}
	if (movingRight)
		{
			transform.position += new Vector3(doorSpd, 0.0f, 0.0f);
		}
	}
}
