using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject redBall;
	public GameObject blueBall;
	public Text whoWins;	

	void Update () {



		if (redBall.activeSelf == false){

			whoWins.color = Color.red;
			whoWins.text = "Red Player Wins!";

		}


		if (blueBall.activeSelf == false) {

			whoWins.color = Color.blue;
			whoWins.text = "Blue Player Wins!";

		}
	}
}
