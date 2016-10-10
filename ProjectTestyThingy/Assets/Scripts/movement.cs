using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public float speed = 10;
	private Vector3 xmovement;
	private Vector3 ymovement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") != 0) {
			xmovement = new Vector3 (speed, 0, 0);
			xmovement *= Input.GetAxis ("Horizontal");

		}

		if (Input.GetAxis ("Vertical") != 0) {
			ymovement = new Vector3 (0, 0, speed);
			ymovement *= Input.GetAxis ("Vertical");
		}
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = xmovement + ymovement;
	}
}
