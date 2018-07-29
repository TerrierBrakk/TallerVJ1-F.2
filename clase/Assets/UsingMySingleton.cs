using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingMySingleton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			{
				//Debug.Log (MySingleton.Instance.name);
				MySingleton.Instance.AddScore(Random.Range(0,100));
			}
		if(Input.GetKeyDown(KeyCode.D))
			{
				MySingleton.Instance.DamagePlayer (Random.Range (0, 100));
			}
	}
}
