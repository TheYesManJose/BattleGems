using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMotor : MonoBehaviour {


	public float bulletSpeed;
	public float deathTimer;
	private Rigidbody RB;
	private Vector3 direction;



	void Start () {


		RB = GetComponent<Rigidbody> ();
		direction = transform.forward * bulletSpeed;
		RB.velocity = direction;
	
		
	}
}
