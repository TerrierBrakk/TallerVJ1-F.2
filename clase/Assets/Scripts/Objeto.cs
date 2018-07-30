using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.CompareTag ("Player")) {
			gameObject.SetActive (false);

		}
	}

	void Update(){
		transform.Rotate(new Vector3(0.5f,0.5f,0.5f));
	}
}
