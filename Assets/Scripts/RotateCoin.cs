using UnityEngine;
using System.Collections;

public class RotateCoin : MonoBehaviour {

	private Transform myTransform;

	[SerializeField]
	float speed = 500.0f;

	void Awake() {
		myTransform = transform;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Rotate (Vector3.up, Time.deltaTime * speed);
	}
}
