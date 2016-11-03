using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
[RequireComponent (typeof (GroundDetector))]
public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	float moveSpeed = 10f;
	[SerializeField]
	float jumpForce = 800f;

	[SerializeField]
	float verticalMaxVelosity = 10f;

	private Rigidbody2D _rigidBody;
	private bool onGroung = false;

	// Use this for initialization
	void Start () {
		_rigidBody = this.GetComponent<Rigidbody2D> ();
		if (_rigidBody == null) {
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) && onGroung) {
			onGroung = false;
			_rigidBody.AddForce( new Vector2(0, jumpForce));
		}
	}

	void FixedUpdate() {

		float move = Input.GetAxis ("Horizontal");
		_rigidBody.velocity = new Vector2 (move * moveSpeed, _rigidBody.velocity.y);

//		if (_rigidBody.velocity.y > verticalMaxVelosity) {
//			_rigidBody.velocity = new Vector2(_rigidBody.velocity.x, verticalMaxVelosity);
//		}
		Debug.Log (_rigidBody.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground") {
			print("On ground");
			onGroung = true;
		}
	}
}
