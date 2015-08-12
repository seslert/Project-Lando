using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform CamPOS;
	public float FollowRate;

	// Use this for initialization
	void Start () {
		transform.rotation = CamPOS.rotation;
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, CamPOS.position, Time.deltaTime * FollowRate);
		transform.rotation = Quaternion.Slerp(transform.rotation, CamPOS.rotation, Time.deltaTime);
	}
}
