using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.forward * Time.deltaTime * Velocity);
		}


	}
}
