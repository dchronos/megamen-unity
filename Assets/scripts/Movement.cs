using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Animator anim;
	float velocity = 0;
	float jump = 0;
	public SpriteRenderer srender;
	public Rigidbody2D rdb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		velocity = Input.GetAxis ("Horizontal");
		jump = Input.GetAxis ("Vertical");

		anim.SetFloat ("vel", velocity);
		if (velocity > 0)
			srender.flipX = false;
		if (velocity < 0)
			srender.flipX = true;
		anim.SetFloat ("vel", Mathf.Abs(velocity));
	}

	void FixedUpdate () {
		//rdb.AddForce (Vector2.right * velocity * (14 - Mathf.Abs (rdb.velocity.x)));
		rdb.velocity = new Vector2 (velocity*4, jump*4);
		Debug.Log (jump);
	}
}
