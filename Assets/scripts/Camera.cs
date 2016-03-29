using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public GameObject megaman;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Megamen X: " + megaman.transform.position.x);
		Debug.Log ("Camera  X: " + transform.position.x);


	}
	void FixedUpdate () {
		if (megaman.transform.position.x > -4.19) {
			transform.position = new Vector3 (megaman.transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
