using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabMotor : MonoBehaviour {

	public float speed = 10;
	public bool canHold = true;
	public GameObject ball;
	public Transform guide;
	public int playerNumber;
	private string inputThrowName;



	void Start(){
		inputThrowName = "Fire" + playerNumber;


	}

	void Update()
	{

	}


}
