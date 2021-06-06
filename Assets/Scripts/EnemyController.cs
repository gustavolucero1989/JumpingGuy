using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float velocity = 2f;
	private Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
		rigidbody2D.velocity = Vector2.left * velocity;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Destroyer") {
			Destroy(gameObject);
		}
	}
}
