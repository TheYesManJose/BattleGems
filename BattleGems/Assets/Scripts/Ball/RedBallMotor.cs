using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallMotor : MonoBehaviour {

		public float pushPower = 200f;
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



			if(other.collider.gameObject.CompareTag("Goal_One")){

				gameObject.SetActive (false);

			}

		}
	}



