using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantAction : MonoBehaviour {

	public float speed = 2.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			transform.position += transform.forward* -1* speed;
		}
		if (Input.GetKey("down")) {
			transform.position += transform.forward* speed;
		}
		if (Input.GetKey("right")) {
			transform.position += transform.right * -1 * speed;
		}
		if (Input.GetKey("left")) {
			transform.position += transform.right * speed;
		}
		if (Input.GetKey("c")) {
			transform.position += new Vector3 (0, 1, 0);
		}
		if (Input.GetKey("g")) {
			transform.position += new Vector3 (0, -1, 0);
		}
		if (Input.GetKey("r")) {
			transform.Rotate(0, 2, 0);
		}
		if (Input.GetKey ("l")) {
			transform.Rotate(0, -2, 0);
		}
	}
}
