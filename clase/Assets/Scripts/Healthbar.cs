using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour {

	public Image health;
	float hp,maxhHp =100;

	// Use this for initialization
	void Start () {
		hp = maxhHp;	
	}
	


	public void damage(float amount)
	{
		
	}
		
}
