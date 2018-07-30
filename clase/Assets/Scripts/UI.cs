using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {
	int contador=0;


	public Text UIScore;
	//int daño=1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		//UIvidas.text = vidas.ToString ();
		UIScore.text = contador.ToString ();
		//perdivida ();
		colectando ();

	}


	void OnTriggerEnter(Collider other)
	{
		

		if (other.gameObject.CompareTag ("Objeto")) {

			contador=contador+1;
		}
	}



	void death()
	{		
			SceneManager.LoadScene ("GameOver");
	}

	void colectando()
	{
		if (contador == 20) 
		{
			Win ();
		}
	}

	void Win()
	{
		print ("Gnaste");
		SceneManager.LoadScene ("Win");
	}
}
