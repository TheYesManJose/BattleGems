using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBallMotor : MonoBehaviour {

	public float pushPower = 20f;
	private Vector3 force;


	private Rigidbody rb;

	void Start () {


		rb = GetComponent<Rigidbody> ();

	}


	void OnCollisionEnter(Collision other){


		if (other.collider.gameObject.CompareTag ("Player")) {


			force = transform.position - other.transform.position;

			rb.AddForce (force * pushPower);

		}



		if(other.collider.gameObject.CompareTag("Goal_Two")){

			gameObject.SetActive (false);

		}

	}
}


