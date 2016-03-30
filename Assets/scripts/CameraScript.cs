using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject megaman;
	float perfectMiddle;
	//Camera camera1 ;

	// Use this for initialization
	void Start () {
		float height = 2f * Camera.main.orthographicSize;
		float width = height * Camera.main.aspect;
		perfectMiddle = -15.5f + width / 2;

		transform.position = new Vector3 (perfectMiddle, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log ("Megamen X: " + megaman.transform.position.x);
//		Debug.Log ("Camera  X: " + transform.position.x);
//		float height = 2f * Camera.main.orthographicSize;
//		float width = height * Camera.main.aspect;
//		float perfectMiddle = -15.5f + width / 2;
//		Debug.Log ("Camera H: " + height);
//		Debug.Log ("Camera W: " + width);
//		Debug.Log ("Camera Limit: " + perfectMiddle);


	}
	void FixedUpdate () {
		if (megaman.transform.position.x > perfectMiddle) {
			transform.position = new Vector3 (megaman.transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
