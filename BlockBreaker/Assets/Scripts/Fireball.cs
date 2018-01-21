using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

	private Paddle paddle;
	private bool hasStarted = false;
	private Rigidbody2D rb;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			if (Input.GetMouseButtonDown(0)) {
				hasStarted = true;
				rb = GetComponent<Rigidbody2D> ();
				rb.velocity = new Vector2 (Random.Range(1f, 3), Random.Range(10f, 15f));
			}
		} else {
			this.transform.Rotate (Vector3.forward);
		}
	}
}
