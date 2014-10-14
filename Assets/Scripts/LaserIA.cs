﻿using UnityEngine;
using System.Collections;

public class LaserIA : MonoBehaviour {

	public float speed = 10.0f;
	public Color laserColor = new Color (184f/255f, 11f/255f, 140f/255f);
	void start(){

	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.color = laserColor;
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("triger");
		if (other.gameObject.CompareTag ("Ennemy")) {
			LifeManager lf =  other.gameObject.GetComponent<LifeManager>();
			lf.hit();

			PushBack pb = other.gameObject.GetComponent<PushBack>();
			pb.push();
		}
		GameObject.Destroy (this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log ("colide");
	}
}
