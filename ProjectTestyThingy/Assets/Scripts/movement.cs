using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public Vector3 vspeed = new Vector3(0, 0, 5);
	public Vector3 hspeed = new Vector3(5, 0, 0);
	private Vector3 xmovement;
	private Vector3 ymovement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Horizontal") != 0) {
			xmovement = new Vector3 (hspeed.x, hspeed.y, hspeed.z);
			xmovement *= Input.GetAxis ("Horizontal");

		}

		if (Input.GetAxis ("Vertical") != 0) {
			ymovement = new Vector3 (vspeed.x, vspeed.y, vspeed.z);
			ymovement *= Input.GetAxis ("Vertical");
		}
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = xmovement + ymovement;
	}
}
