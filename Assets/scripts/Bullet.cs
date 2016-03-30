using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	//public GameObject enemy;
	//public Camera camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnBecameInvisible() {
		Destroy (gameObject);
	}
	void OnCollisionEnter2D (Collision2D col)
	{	
		Debug.Log ("Col : " + col.gameObject.name);
		if(col.gameObject.name == "enemy2")
		{
			Destroy(gameObject);
		}
	}
}
